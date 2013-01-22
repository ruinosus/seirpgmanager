using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using SeiRPGManager.Entidades.Modelo.ClassesBasicas;
using System.Data;

namespace SeiRPGManager.Negocio
{
    public abstract class PersonagemExtensorServico<T, TBaseFormModel> 
        where T : Humano
        where TBaseFormModel : EntidadeFormModel<T>
    {
        private Type type;

        protected PersonagemExtensorServico()
        {
            type = typeof(T);
        }

        protected ObjectContext Context
        {
            get { return GerenciadorContexto.ObjectContext; }
        }

        public virtual void Salvar(TBaseFormModel model)
        {
            Validar(model.Entidade);

            using (var context = Context)
            {
                Humano humano = (Humano)context.GetObjectByKey(context.CreateEntityKey("Humano", model.Entidade));

                if (humano is T)
                {
                    context.ApplyOriginalValues("Humano", humano);

                    T entidade = (T)humano;

                    PreValoresCorrente(entidade, model.Entidade);

                    AplicarValores(context, entidade, false);

                    context.ApplyCurrentValues("Humano", entidade);

                    PosValoresCorrente(context, model.Entidade);

                    foreach (var item in model.Lixeira)
                    {
                        context.DeleteObject(context.GetObjectByKey(new EntityKey(string.Format("{0}.{1}", GerenciadorContexto.Nome, item.Key), "Id", item.Value)));
                    }
                }
                else
                {
                    if (!GerenciadorAcesso.UsuarioCorrentePertence(Tipo.Narrador))
                    {
                        ValidarPersonagemInicial(context, model.Entidade);
                    }

                    #region Copiando

                    model.Entidade.Id = 0;
                    model.Entidade.Nome = humano.Nome;
                    model.Entidade.JogadorId = humano.JogadorId;
                    model.Entidade.CronicaId = humano.CronicaId;
                    model.Entidade.Virtude = humano.Virtude;
                    model.Entidade.Vicio = humano.Vicio;
                    model.Entidade.Tamanho = humano.Tamanho;
                    model.Entidade.Experiencia = humano.Experiencia;
                    model.Entidade.Moralidade = humano.Moralidade;
                    model.Entidade.Vitalidade = humano.Vitalidade;
                    model.Entidade.DanoContusao = humano.DanoContusao;
                    model.Entidade.DanoLetal = humano.DanoLetal;
                    model.Entidade.DanoAgravado = humano.DanoAgravado;
                    model.Entidade.Vontade = humano.Vontade;
                    model.Entidade.VontadeTemporaria = humano.VontadeTemporaria;
                    model.Entidade.Penalidade = humano.Penalidade;
                    model.Entidade.Forca = humano.Forca;
                    model.Entidade.Destreza = humano.Destreza;
                    model.Entidade.Vigor = humano.Vigor;
                    model.Entidade.Presenca = humano.Presenca;
                    model.Entidade.Manipulacao = humano.Manipulacao;
                    model.Entidade.Autocontrole = humano.Autocontrole;
                    model.Entidade.Inteligencia = humano.Inteligencia;
                    model.Entidade.Raciocinio = humano.Raciocinio;
                    model.Entidade.Perseveranca = humano.Perseveranca;
                    model.Entidade.Armamento = humano.Armamento;
                    model.Entidade.ArmasDeFogo = humano.ArmasDeFogo;
                    model.Entidade.Briga = humano.Briga;
                    model.Entidade.Conducao = humano.Conducao;
                    model.Entidade.Dissimulacao = humano.Dissimulacao;
                    model.Entidade.Esportes = humano.Esportes;
                    model.Entidade.Furto = humano.Furto;
                    model.Entidade.Sobrevivencia = humano.Sobrevivencia;
                    model.Entidade.Astucia = humano.Astucia;
                    model.Entidade.Empatia = humano.Empatia;
                    model.Entidade.Expressao = humano.Expressao;
                    model.Entidade.Intimidacao = humano.Intimidacao;
                    model.Entidade.Manha = humano.Manha;
                    model.Entidade.Persuasao = humano.Persuasao;
                    model.Entidade.Socializacao = humano.Socializacao;
                    model.Entidade.TratoAnimais = humano.TratoAnimais;
                    model.Entidade.Ciencias = humano.Ciencias;
                    model.Entidade.Erudicao = humano.Erudicao;
                    model.Entidade.Informatica = humano.Informatica;
                    model.Entidade.Investigacao = humano.Investigacao;
                    model.Entidade.Medicina = humano.Medicina;
                    model.Entidade.Ocultismo = humano.Ocultismo;
                    model.Entidade.Oficios = humano.Oficios;
                    model.Entidade.Politica = humano.Politica;

                    model.Entidade.Especializacoes = new List<HumanoEspecializacao>();

                    foreach (var item in humano.Especializacoes)
                    {
                        HumanoEspecializacao obj = new HumanoEspecializacao();
                        obj.HumanoId = model.Entidade.Id;
                        obj.EspecializacaoId = item.EspecializacaoId;
                        model.Entidade.Especializacoes.Add(obj);
                    }

                    model.Entidade.Vantagens = new List<HumanoVantagem>();

                    foreach (var item in humano.Vantagens)
                    {
                        HumanoVantagem obj = new HumanoVantagem();
                        obj.HumanoId = model.Entidade.Id;
                        obj.VantagemId = item.VantagemId;
                        obj.Nivel = item.Nivel;
                        model.Entidade.Vantagens.Add(obj);
                    }

                    model.Entidade.Armas = new List<HumanoArma>();

                    foreach (var item in humano.Armas)
                    {
                        HumanoArma obj = new HumanoArma();
                        obj.HumanoId = model.Entidade.Id;
                        obj.ArmaId = item.ArmaId;
                        model.Entidade.Armas.Add(obj);
                    }

                    model.Entidade.Itens = new List<HumanoItem>();

                    foreach (var item in humano.Itens)
                    {
                        HumanoItem obj = new HumanoItem();
                        obj.HumanoId = model.Entidade.Id;
                        obj.ItemId = item.ItemId;
                        model.Entidade.Itens.Add(obj);
                    }

                    #endregion

                    AplicarValores(context, model.Entidade, true);

                    context.DeleteObject(humano);
                    context.AddObject("Humano", model.Entidade);
                }

                context.SaveChanges();
            }
        }

        public void Consultar(TBaseFormModel model, long id)
        {
            using (var context = Context)
            {
                T entidade = context.CreateObjectSet<Humano>().OfType<T>().SingleOrDefault(ent => ent.Id == id);

                if (entidade == null)
                {
                    model.Entidade = Activator.CreateInstance<T>();
                    model.Entidade.Id = id;
                }
                else
                {
                    CarregarPropriedades(context, entidade);
                    model.Entidade = entidade;
                }
            }
        }

        internal void Observar(HumanoServico humanoServico)
        {
            CriadorTipoEntidade.Instancia.OnCriar += new Action<int, Bolsa<Humano>>(CriadorTipoEntidadeOnCriar);

            humanoServico.OnEspecificarTipoEntidade += new Action<HumanoFormModel>(HumanoOnEspecificarTipoEntidade);
            humanoServico.OnBloquearOperacao += new Action<Type, Bolsa<bool>>(HumanoOnBloquearOperacao);
            humanoServico.OnEvoluir += new Action<ObjectContext, Humano, TipoCampo, long, int>(HumanoOnEvoluir);
            humanoServico.OnPreOperacao += new Action<ObjectContext, HumanoFormModel>(HumanoOnPreOperacao);
            humanoServico.OnPermitirVantagem += new Action<Type, Vantagem, Bolsa<bool>>(HumanoOnPermitirVantagem);
            humanoServico.OnValidarUsoVantagens += new Action<Humano>(humanoOnValidarUsoVantagens);
            humanoServico.OnGerenciarEnergia += new Action<ObjectContext, Humano, bool, int, IList<string>>(HumanoOnGerenciarEnergia);
        }

        private void humanoOnValidarUsoVantagens(Humano humano)
        {
            if (humano is T)
            {
                ValidarUsoVantagens(humano.Vantagens);
            }
        }

        private void HumanoOnPreOperacao(ObjectContext context, HumanoFormModel model)
        {
            if (model.Entidade is T)
            {
                PreOperacao(context, (T)model.Entidade);
            }
        }

        private void HumanoOnPermitirVantagem(Type typeEntidade, Vantagem vantagem, Bolsa<bool> bolsa)
        {
            if (typeEntidade.IsSubclassOf(type) && PermitirVantagem(vantagem))
            {
                bolsa.Objeto = true;
            }
        }

        private void CriadorTipoEntidadeOnCriar(int tipoEntidade, Bolsa<Humano> bolsa)
        {
            if (bolsa.Objeto == null && type.Name.Equals(((TipoPersonagem)tipoEntidade).ToString()))
            {
                bolsa.Objeto = Activator.CreateInstance<T>();
            }
        }

        private void HumanoOnEspecificarTipoEntidade(HumanoFormModel model)
        {
            if (model.Entidade is T)
            {
                model.TipoEntidade = (int) Enum.Parse(typeof(TipoPersonagem), type.Name);
            }
        }

        private void HumanoOnBloquearOperacao(Type typeEntidade, Bolsa<bool> bolsa)
        {
            if (typeEntidade.IsSubclassOf(type))
            {
                bolsa.Objeto = true;
            }           
        }

        private void HumanoOnEvoluir(ObjectContext context, Humano humano, TipoCampo tipoCampo, long id, int incremento)
        {
            if (humano is T)
            {
                Evoluir(context, (T)humano, tipoCampo, id, incremento);
                Validar((T)humano);
            }
        }

        private void HumanoOnGerenciarEnergia(ObjectContext context, Humano humano, bool sinal, int valor, IList<string> status)
        {
            if (humano is T)
            {
                GerenciarEnergia(context, (T)humano, sinal, valor, status);
            }
        }

        protected abstract void PreOperacao(ObjectContext context, T entidade);

        protected abstract void AplicarValores(ObjectContext context, T entidade, bool inicial);

        protected abstract void ValidarPersonagemInicial(ObjectContext context, T entidade);

        protected abstract void Evoluir(ObjectContext context, T entidade, TipoCampo tipoCampo, long id, int incremento);

        protected abstract bool PermitirVantagem(Vantagem vantagem);

        protected abstract void PreValoresCorrente(T entidade, T entidadeModel);

        protected abstract void PosValoresCorrente(ObjectContext context, T entidade);

        protected abstract void CarregarPropriedades(ObjectContext context, T entidade);

        protected abstract void GerenciarEnergia(ObjectContext context, T entidade, bool sinal, int valor, IList<string> status);

        protected abstract void Validar(T entidade);

        protected abstract void ValidarUsoVantagens(ICollection<HumanoVantagem> vantagens);
    }
}
