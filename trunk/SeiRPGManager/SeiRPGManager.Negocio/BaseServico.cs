// -----------------------------------------------------------------------
// <copyright file="BaseServico.cs" company="SeiRPGManager">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Negocio
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class BaseServico<T, TBaseFormModel> : IServico<T, TBaseFormModel>
        where T : Entidade
        where TBaseFormModel : EntidadeFormModel<T>
    {
        private PropertyInfo[] properties;

        internal BaseServico()
        {
            properties = typeof(T).GetProperties();
        }

        protected ObjectContext Context
        {
            get { return GerenciadorContexto.ObjectContext; }
        }

        public virtual void Salvar(TBaseFormModel model)
        {
            using (var context = Context)
            {
                PreOperacao(context, model);

                string nomeTipo = typeof(T).Name;

                if (model.Entidade.Id == 0)
                {
                    context.AddObject(nomeTipo, model.Entidade);
                }
                else
                {
                    context.ApplyOriginalValues(nomeTipo, context.GetObjectByKey(context.CreateEntityKey(nomeTipo, model.Entidade)));
                    context.ApplyCurrentValues(nomeTipo, model.Entidade);

                    for (int i = 0; i < properties.Length; i++)
                    {
                        Type type = properties[i].PropertyType;
                        if (type.IsSubclassOf(typeof(Entidade)))
                        {
                            Entidade item = (Entidade)properties[i].GetValue(model.Entidade, null);
                            if (item != null)
                            {
                                Manter(context, type.Name, item);
                            }
                        }
                        else if (type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(ICollection<>)))
                        {
                            string nomeTipoCollection = properties[i].PropertyType.GetGenericArguments()[0].Name;
                            object obj = properties[i].GetValue(model.Entidade, null);
                            if (obj != null)
                            {
                                foreach (var item in ((IEnumerable<Entidade>)obj).ToArray())
                                {
                                    Manter(context, nomeTipoCollection, item);
                                }
                            }
                        }
                    }

                    foreach (var item in model.Lixeira)
                    {
                        context.DeleteObject(context.GetObjectByKey(new EntityKey(string.Format("{0}.{1}", GerenciadorContexto.Nome, item.Key), "Id", item.Value)));
                    }
                }

                SalvarContexto(context);
            }
        }

        protected virtual void PreOperacao(ObjectContext context, TBaseFormModel model)
        {
        }

        public virtual void Excluir(params long[] ids)
        {
            using (var context = Context)
            {
                ObjectSet<T> objectSet = context.CreateObjectSet<T>();

                foreach (var item in ids)
                {
                    objectSet.DeleteObject(objectSet.Single(ent => ent.Id == item));
                }

                SalvarContexto(context);
            }
        }

        public virtual T Consultar(long id, Carga<T> carga = null)
        {
            using (var context = Context)
            {
                ObjectQuery<T> objectQuery = context.CreateObjectSet<T>();

                if (carga != null)
                {
                    foreach (var item in carga)
                    {
                        objectQuery = objectQuery.Include(item);
                    } 
                }

                return objectQuery.Single(ent => ent.Id == id);
            }
        }

        public virtual void Consultar(TBaseFormModel model, long id, Carga<T> carga)
        {
            using (var context = Context)
            {
                ObjectQuery<T> objectQuery = context.CreateObjectSet<T>();

                foreach (var item in carga)
                {
                    objectQuery = objectQuery.Include(item);
                }

                model.Entidade = objectQuery.Single(ent => ent.Id == id);
            }
        }

        public virtual void Filtrar(FiltrarModel<T> model)
        {
            StringBuilder stringBuilder = new StringBuilder();
            List<ObjectParameter> listObjects = new List<ObjectParameter>();
            for (int i = 0; i < properties.Length; i++)
            {
                object obj = properties[i].GetValue(model.Exemplo, null);
                bool ignorar = false;
                Type type = properties[i].PropertyType;
                if (type.IsValueType && !(type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>))))
                {
                    ignorar = obj.Equals(Activator.CreateInstance(type));
                }
                else
                {
                    if (type.IsGenericType && type.GetGenericArguments()[0].IsEnum)
                    {
                        ignorar = true;
                    }
                    else
                    {
                        ignorar = obj == null;
                    }                
                }

                if (!ignorar)
                {
                    if (stringBuilder.Length > 0)
                    {
                        stringBuilder.Append(" and ");
                    }

                    if (type == typeof(string))
                    {
                        stringBuilder.AppendFormat("it.{0} like @p{1}", properties[i].Name, i);
                        obj = string.Format("%{0}%", obj);
                    }
                    else
                    {
                        stringBuilder.AppendFormat("it.{0} = @p{1}", properties[i].Name, i);
                    }

                    listObjects.Add(new ObjectParameter(string.Format("p{0}", i), obj));
                }
            }

            using (var context = Context)
            {
                ObjectQuery<T> objectQuery = context.CreateObjectSet<T>();

                foreach (var item in model.Carga)
                {
                    objectQuery = objectQuery.Include(item);
                }

                if (!model.Inativados)
                {
                    if (stringBuilder.Length > 0)
                    {
                        stringBuilder.Append(" and ");
                    }

                    stringBuilder.Append("it.Inativado == false");
                }

                if (stringBuilder.Length == 0)
                {
                    model.Resultado = objectQuery;
                }
                else
                {
                    model.Resultado = objectQuery.Where(stringBuilder.ToString(), listObjects.ToArray<ObjectParameter>());
                }
            }
        }

        public bool BloquearOperacao(long id, string usuarioCorrente)
        {
            string login = null;

            using (var context = Context)
            {
                login = LoginUsuarioPermitido(context.CreateObjectSet<T>().SingleOrDefault(ent => ent.Id == id));
            }

            if (string.IsNullOrEmpty(login))
            {
                return false;
            }

            return !GerenciadorAcesso.UsuarioCorrentePertence(Tipo.Editor)
                && !usuarioCorrente.Equals(login);
        }

        protected virtual string LoginUsuarioPermitido(T entidade)
        {
            return null;
        }

        private static void Manter(ObjectContext context, string nomeTipo, Entidade item)
        {
            if (item.Id == 0)
            {
                context.AddObject(nomeTipo, item);
            }
            else
            {
                context.ApplyOriginalValues(nomeTipo, context.GetObjectByKey(context.CreateEntityKey(nomeTipo, item)));
                context.ApplyCurrentValues(nomeTipo, item);
            }
        }

        protected static void SalvarContexto(ObjectContext context)
        {
            try
            {
                context.SaveChanges();
            }
            catch (UpdateException ex)
            {
                if (ex.InnerException.Message.IndexOf("UNIQUE KEY") > -1)
                {
                    throw new ViolacaoChaveUnicaException(ex.InnerException);
                }
                else
                {
                    throw new ViolacaoReferenciaException(ex.InnerException);
                }
            }
        }
    }
}
