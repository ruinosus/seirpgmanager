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
        public ConceitoPlanilha Conceito { get; set; }

        public AtributoPlanilha Atributo { get; set; }

        public HabilitadorPlanilha Habilitador { get; set; }

        public List<TalentoPlanilha> Talento { get; set; }

        public List<PrecedentePlanilha> Precedente { get; set; }
        
        public CapacidadePlanilha Capacidade { get; set; }

        public List<ArmaPlanilha> Arma { get; set; }

        public List<EquipamentoPlanilha> Equipamento { get; set; }

        public List<BarraSaudePlanilha> BarraSaude { get; set; }

        public BarraEnergiaPlanilha BarraEnergia { get; set; }

        public Planilha()
        {

        }
    }
}
