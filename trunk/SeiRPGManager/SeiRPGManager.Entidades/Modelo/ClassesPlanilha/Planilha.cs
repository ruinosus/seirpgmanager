// -----------------------------------------------------------------------
// <copyright file="Planilha.cs" company="Ludus Interactive">
// Todos os direitos reservados.
// </copyright>
// -----------------------------------------------------------------------
namespace SeiRPGManager.Entidades.Modelo.ClassesPlanilha
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Planilha
    {
        #region Conceito
        
        public ConceitoPlanilha Conceito { get; set; }

        #endregion

        #region Atributos

        public AtributosFisicosPlanilha AtributosFisicos { get; set; }
        public AtributosMentaisPlanilha AtributosMentais { get; set; }
        public AtributosSobrenaturaisPlanilha AtributosSobrenaturais { get; set; }

        #endregion

        #region Habilitadores

        public HabilitadorAtletico Atletico { get; set; }

        public HabilitadorCombateProximo CombateProximo { get; set; }
        
        public HabilitadorCombateAfastado CombateAfastado { get; set; }

        public HabilitadorInstrucao Instrucao { get; set; }

        public HabilitadorSocial Social { get; set; }

        public HabilitadorPerspicacia Perspicacia { get; set; }

        public HabilitadorSobrenatural HabilitadorSobrenatural1 { get; set; }

        public HabilitadorSobrenatural HabilitadorSobrenatural2 { get; set; }

        public HabilitadorSobrenatural HabilitadorSobrenatural3 { get; set; }
        
        #endregion

        #region Talentos

        public IList<TalentoPlanilha> Talentos { get; set; }

        #endregion

        #region Precedentes

        public IList<PrecedentePlanilha> Precedentes { get; set; }

        #endregion

        #region Capacidades

        public CapacidadePlanilha Capacidade { get; set; }

        #endregion

        #region Armas

        public List<ArmaPlanilha> Armas { get; set; }

        #endregion

        #region Equipamentos

        public List<EquipamentoPlanilha> Equipamentos { get; set; }

        #endregion

        #region Barra Saude

        public List<SaudePlanilha> EstadosSaude { get; set; }

        #endregion

        #region Barra Energia

        public BarraEnergiaPlanilha BarraEnergia { get; set; }

        #endregion

    }
}
