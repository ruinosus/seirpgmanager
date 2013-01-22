// -----------------------------------------------------------------------
// <copyright file="SeiRPGManagerDAO.cs" company="Playware">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.DAL.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Objects;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
    using SeiRPGManager.DAL.Repositorio.Interface;
    using System.Data.Objects.DataClasses;
    using SeiRPGManager.DAL.Repositorio;
    using Storytelling.Negocio.Excecoes;
    using System.Data.Entity;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SeiRPGManagerDAO<T> : ISeiRPGManagerDAO<T> where T : Entidade
    {
        internal SeiRPGManagerContexto context;
        internal DbSet<T> dbSet;

        public SeiRPGManagerDAO(SeiRPGManagerContexto context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            //this.context.
        }

        public SeiRPGManagerDAO()
        {
            this.context = new SeiRPGManagerContexto();
            this.dbSet = context.Set<T>();
            
        }

        //    /// <summary>
        //    /// TODO: Update Header
        //    /// </summary>
        //    private PropertyInfo[] properties;

        //    /// <summary>
        //    /// TODO: Update Header
        //    /// </summary>
        //    internal SeiRPGManagerDAO()
        //    {
        //        this.properties = typeof(T).GetProperties();
        //    }


        //    /// <summary>
        //    /// TODO: Update Header
        //    /// </summary>
        //    /// <returns>TODO: Update Header</returns>
        //    public IQueryable<T> ObterTodos<T>()
        //    {
        //        using (var contexto = Contexto)
        //        {
        //            return contexto.CreateObjectSet<T>(); 
        //        }
        //    }


        //    /// <summary>
        //    /// TODO: Update Header
        //    /// </summary>
        //    /// <param name="entidade"></param>
        //    public void Inserir(T entidade)
        //    {
        //        contexto.ApplyCurrentValues<T>(entidade.GetType().Name, entidade); 
        //    }

        //    /// <summary>
        //    /// TODO: Update Header
        //    /// </summary>
        //    /// <param name="entidade"></param>
        //    public void Atualizar(T entidade)
        //    {
        //        using (var contexto = Context)
        //        {
        //            contexto.ApplyCurrentValues<T>(entidade.GetType().Name, entidade);
        //        }
        //    }

        //    /// <summary>
        //    /// TODO: Update Header
        //    /// </summary>
        //    /// <param name="ids"></param>
        //    /// <returns></returns>
        //    public virtual bool Excluir(params long[] ids)
        //    {
        //        using (var context = this.Context)
        //        {
        //            ObjectSet<T> objectSet = context.CreateObjectSet<T>();

        //            foreach (var item in ids)
        //            {
        //                objectSet.DeleteObject(objectSet.Single(ent => ent.Id == item));
        //            }

        //            return SalvarContexto(context);
        //        }
        //    }

        //    /// <summary>
        //    /// TODO: Update Header
        //    /// </summary>
        //    /// <param name="filtro"></param>
        //    /// <returns></returns>
        //    public IQueryable<T> Pesquisar(Expression<Func<T, bool>> filtro)
        //    {
        //        using (var contexto = Context)
        //        {
        //            return contexto.CreateObjectSet<T>().Where(filtro);
        //        }
        //    }


        /// <summary>
        /// TODO: Update Header
        /// </summary>
        /// <param name="contexto"></param>
        /// <returns></returns>
        public bool SalvarContexto(ObjectContext contexto)
        {
            try
            {
                bool retorno = false;

                if (contexto.SaveChanges() == 1)
                {
                    retorno = true;
                }
                return retorno;
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

        //    /// <summary>
        //    /// TODO: Update Header
        //    /// </summary>
        //    /// <param name="context"></param>
        //    /// <param name="nomeTipo"></param>
        //    /// <param name="item"></param>
        //    private static void Manter(ObjectContext context, string nomeTipo, Entidade item)
        //    {
        //        if (item.Id == 0)
        //        {
        //            context.AddObject(nomeTipo, item);
        //        }
        //        else
        //        {
        //            context.ApplyOriginalValues(nomeTipo, context.GetObjectByKey(context.CreateEntityKey(nomeTipo, item)));
        //            context.ApplyCurrentValues(nomeTipo, item);
        //        }
        //    }
        //}
        public IQueryable<T> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void InserirOuAtualizar(T entidade)
        {
            //dbSet.Add(entidade);
            //var abc = this.context.Agendas;

            this.context.Set<T>().Add(entidade);
            
            this.context.SaveChanges();
        }

        public void Atualizar(T entidade)
        {
            throw new NotImplementedException();
        }

        public bool Excluir(params long[] ids)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Pesquisar(Expression<Func<T, bool>> filtro)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
