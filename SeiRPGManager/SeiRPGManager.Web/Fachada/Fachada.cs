using SeiRPGManager.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeiRPGManager.Web.Fachada
{
    public class Fachada
    {
        private static Fachada fachadaSingleton = null;

        // repare no construtor privado, somente métodos dessa classe pode utiliza-lo (no caso getInstance()  
        private Fachada()
        {
            //algum código aqui  
        }

        // retorna a única instancia  
        public static Fachada getInstance()
        {
            if (fachadaSingleton == null)
            {
                fachadaSingleton = new Fachada();
            }
            return fachadaSingleton;
        }

        AgendaNegocio agendaNegocio = new AgendaNegocio();
        AnotacaoNegocio anotacaoNegocio = new AnotacaoNegocio();
        ArmaNegocio armaNegocio = new ArmaNegocio();
        CampanhaNegocio campanhaNegocio = new CampanhaNegocio();
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        EnredoPoolNegocio enredoPoolNegocio = new EnredoPoolNegocio();
        EquipamentoNegocio equipamentoNegocio = new EquipamentoNegocio();
        EspecializacaoNegocio especializacaoNegocio = new EspecializacaoNegocio();
        HabilitadorNegocio habilitadorNegocio = new HabilitadorNegocio();
        JogadorNegocio jogadorNegocio = new JogadorNegocio();
        MensagemNegocio mensagemNegocio = new MensagemNegocio();
        NomePoolNegocio nomePoolNegocio = new NomePoolNegocio();
        OcupacaoNegocio ocupacaoNegocio = new OcupacaoNegocio();
        ParametroNegocio parametroNegocio = new ParametroNegocio();
        PersonagemNegocio personagemNegocio = new PersonagemNegocio();
        PersonalidadeNegocio personalidadeNegocio = new PersonalidadeNegocio();
        PlanilhaNegocios planilhaNegocio = new PlanilhaNegocios();
        PrecedenteNegocio precedenteNegocio = new PrecedenteNegocio();
        PrologoPoolNegocio prologoPoolNegocio = new PrologoPoolNegocio();
        RacaNegocio racaNegocio = new RacaNegocio();
        SistemaNegocio sistemaNegocio = new SistemaNegocio();
        TalentoNegocio talentoNegocio = new TalentoNegocio();


        #region Métodos Agenda

        #endregion

        #region Métodos Anotacao

        #endregion

        #region Métodos Arma

        #endregion

        #region Métodos Campanha

        #endregion

        #region Métodos Categoria

        #endregion

        #region Métodos Enredo

        #endregion

        #region Métodos Equipamento

        #endregion

        #region Métodos Especializacao

        #endregion

        #region Métodos Habilitador

        #endregion

        #region Métodos Jogador

        #endregion

        #region Métodos Mensagem

        #endregion

        #region Métodos NomePool

        #endregion

        #region Métodos Ocupacao

        #endregion

        #region Métodos Parametro

        #endregion

        #region Métodos Personagem

        #endregion

        #region Métodos Planilha

        #endregion

        #region Métodos Precedentes

        #endregion

        #region Métodos PrologoPool

        #endregion

        #region Métodos Raca

        #endregion

        #region Métodos Saude

        #endregion

        #region Métodos Sistema

        #endregion

        #region Métodos Talento

        #endregion

        //métodos da fachada  

        public void algumMetodoDaFachada1()
        {
            //algum codigo aqui  
        }

        public void algumMetodoDaFachada2()
        {
            //algum codigo aqui  
        }
    }  
}