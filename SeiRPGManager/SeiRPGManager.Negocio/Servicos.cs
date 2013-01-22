// -----------------------------------------------------------------------
// <copyright file="Servicos.cs" company="SeiRPGManager">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Negocio
{
    using SeiRPGManager.Entidades;
    using SeiRPGManager.Entidades.Modelo;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public static class Servicos
    {
        private static IServico<Agrupamento, AgrupamentoFormModel> agrupamento;
        private static IServico<Arma, ArmaFormModel> arma;
        private static IServico<Cla, ClaFormModel> cla;
        private static CronicaServico cronica;
        private static IServico<Devocao, DevocaoFormModel> devocao;
        private static IServico<Disciplina, DisciplinaFormModel> disciplina;
        private static IServico<Especializacao, EspecializacaoFormModel> especializacao;
        private static HumanoServico humano;
        private static IServico<Item, ItemFormModel> item;
        private static IServico<Ritual, RitualFormModel> ritual;
        private static UsuarioServico usuario;
        private static VampiroServico vampiro;
        private static IServico<Vantagem, VantagemFormModel> vantagem;

        static Servicos()
        {
            Vampiro.Observar(Humano);
        }

        public static IServico<Agrupamento, AgrupamentoFormModel> Agrupamento
        {
            get
            {
                Servicos.agrupamento = Servicos.agrupamento ?? new BaseServico<Agrupamento, AgrupamentoFormModel>();
                return Servicos.agrupamento;
            }
        }

        public static IServico<Arma, ArmaFormModel> Arma
        {
            get 
            {
                Servicos.arma = Servicos.arma ?? new BaseServico<Arma, ArmaFormModel>();
                return Servicos.arma; 
            }
        }

        public static IServico<Cla, ClaFormModel> Cla
        {
            get
            {
                Servicos.cla = Servicos.cla ?? new BaseServico<Cla, ClaFormModel>();
                return Servicos.cla;
            }
        }

        public static CronicaServico Cronica
        {
            get
            {
                Servicos.cronica = Servicos.cronica ?? new CronicaServico();
                return Servicos.cronica;
            }
        }

        public static IServico<Devocao, DevocaoFormModel> Devocao
        {
            get
            {
                Servicos.devocao = Servicos.devocao ?? new BaseServico<Devocao, DevocaoFormModel>();
                return Servicos.devocao;
            }
        }

        public static IServico<Disciplina, DisciplinaFormModel> Disciplina
        {
            get
            {
                Servicos.disciplina = Servicos.disciplina ?? new BaseServico<Disciplina, DisciplinaFormModel>();
                return Servicos.disciplina;
            }
        }

        public static IServico<Especializacao, EspecializacaoFormModel> Especializacao
        {
            get
            {
                Servicos.especializacao = Servicos.especializacao ?? new BaseServico<Especializacao, EspecializacaoFormModel>();
                return Servicos.especializacao;
            }
        }

        public static HumanoServico Humano
        {
            get
            {
                Servicos.humano = Servicos.humano ?? new HumanoServico();
                return Servicos.humano;
            }
        }

        public static IServico<Item, ItemFormModel> Item
        {
            get
            {
                Servicos.item = Servicos.item ?? new BaseServico<Item, ItemFormModel>();
                return Servicos.item;
            }
        }

        public static IServico<Ritual, RitualFormModel> Ritual
        {
            get
            {
                Servicos.ritual = Servicos.ritual ?? new BaseServico<Ritual, RitualFormModel>();
                return Servicos.ritual;
            }
        }

        public static UsuarioServico Usuario
        {
            get
            {
                Servicos.usuario = Servicos.usuario ?? new UsuarioServico();
                return Servicos.usuario;
            }
        }

        public static VampiroServico Vampiro
        {
            get
            {
                Servicos.vampiro = Servicos.vampiro ?? new VampiroServico();
                return Servicos.vampiro;
            }
        }

        public static IServico<Vantagem, VantagemFormModel> Vantagem
        {
            get
            {
                Servicos.vantagem = Servicos.vantagem ?? new BaseServico<Vantagem, VantagemFormModel>();
                return Servicos.vantagem;
            }
        }
    }
}
