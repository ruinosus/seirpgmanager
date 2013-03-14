using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Entidades.Modelo.ClassesPlanilha
{
    public class AtributoPlanilha
    {
        public int Valor
        {
            get;
            set
            {
                if (value > 10)
                {
                    Valor = 10;
                }
                else if (value < 0)
                {
                    Valor = 0;
                }
                else
                {
                    Valor = value;
                }
            }
        }
        public string Descricao { get; set; }
    }

    public class AtributosFisicosPlanilha
    {
        public int Prioridade { get; set; }

        public AtributoPlanilha Forca { get; set; }
        public AtributoPlanilha Destreza { get; set; }
        public AtributoPlanilha Resistencia { get; set; }
    }

    public class AtributosMentaisPlanilha
    {
        public int Prioridade { get; set; }

        public AtributoPlanilha Intelecto { get; set; }
        public AtributoPlanilha Influencia { get; set; }
        public AtributoPlanilha Percepcao { get; set; }
    }

    public class AtributosSobrenaturaisPlanilha
    {
        public int Prioridade { get; set; }

        public AtributoPlanilha Determinacao { get; set; }
        public AtributoPlanilha Intuicao { get; set; }
        public AtributoPlanilha Imunidade { get; set; }
    }

    public class HabilitadorPlanilha
    {
        public int Valor
        {
            get;
            set
            {
                if (value > 5)
                {
                    Valor = 5;
                }
                else if (value < 0)
                {
                    Valor = 0;
                }
                else
                {
                    Valor = value;
                }
            }
        }
        public string Descricao { get; set; }
    }

    public class EspecializacaoPlanilha
    {
        public int Valor
        {
            get;
            set
            {
                if (value > 3)
                {
                    Valor = 3;
                }
                else if (value < 0)
                {
                    Valor = 0;
                }
                else
                {
                    Valor = value;
                }
            }
        }
        
        public string Descricao { get; set; }

        public bool Requerido { get; set; }
    }
    
    public class HabilitadorAtletico : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha Salto { get; set; }
        private EspecializacaoPlanilha Corrida { get; set; }
        private EspecializacaoPlanilha Escalada { get; set; }
        private EspecializacaoPlanilha Natacao { get; set; }
        private EspecializacaoPlanilha Esporte { get; set; }
    }

    public class HabilitadorCombateProximo : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha CombateDesarmado { get; set; }
        private EspecializacaoPlanilha Evasao { get; set; }
        private EspecializacaoPlanilha ArmBrancaCurta { get; set; }
        private EspecializacaoPlanilha ArmBrancaMedia { get; set; }
        private EspecializacaoPlanilha ArmBrancaLonga { get; set; }
    }

    public class HabilitadorCombateAfastado : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha Armamento { get; set; }
        private EspecializacaoPlanilha ArmImpulso { get; set; }
        private EspecializacaoPlanilha ArmFogoLeve { get; set; }
        private EspecializacaoPlanilha ArmFogoMedia { get; set; }
        private EspecializacaoPlanilha ArmFogoPesada { get; set; }
    }

    public class HabilitadorCombateAfastado : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha Armamento { get; set; }
        private EspecializacaoPlanilha ArmImpulso { get; set; }
        private EspecializacaoPlanilha ArmFogoLeve { get; set; }
        private EspecializacaoPlanilha ArmFogoMedia { get; set; }
        private EspecializacaoPlanilha ArmFogoPesada { get; set; }
    }

    public class HabilitadorCombateAfastado : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha Armamento { get; set; }
        private EspecializacaoPlanilha ArmImpulso { get; set; }
        private EspecializacaoPlanilha ArmFogoLeve { get; set; }
        private EspecializacaoPlanilha ArmFogoMedia { get; set; }
        private EspecializacaoPlanilha ArmFogoPesada { get; set; }
    }

    public class HabilitadorInstrucao : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha Medicina { get; set; }
        private EspecializacaoPlanilha Computacao { get; set; }
        private EspecializacaoPlanilha Linguistica { get; set; }
        private EspecializacaoPlanilha Conhecimento { get; set; }
        private EspecializacaoPlanilha Ocultismo { get; set; }
    }

    public class HabilitadorSocial : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha Empatia { get; set; }
        private EspecializacaoPlanilha TratoAnimais { get; set; }
        private EspecializacaoPlanilha Labia { get; set; }
        private EspecializacaoPlanilha Malandragem { get; set; }
        private EspecializacaoPlanilha Performance { get; set; }
    }

    public class HabilitadorPerspicacia : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha Investigacao { get; set; }
        private EspecializacaoPlanilha Furtividade { get; set; }
        private EspecializacaoPlanilha Prestidigitacao { get; set; }
        private EspecializacaoPlanilha Reparo { get; set; }
        private EspecializacaoPlanilha Subterfugio { get; set; }
    }

    public class HabilitadorSobrenatural : HabilitadorPlanilha
    {
        private EspecializacaoPlanilha Slot1 { get; set; }
        private EspecializacaoPlanilha Slot2 { get; set; }
        private EspecializacaoPlanilha Slot3 { get; set; }
        private EspecializacaoPlanilha Slot4 { get; set; }
        private EspecializacaoPlanilha Slot5 { get; set; }
    }

    public class ArmaPlanilha
    {
        public int Pente { get; set; }
        public int Ajuste { get; set; }
        public string Tipo { get; set; }
        public int Alcance { get; set; }
        public string Tamanho { get; set; }
    }

    public class ConceitoPlanilha
    {
        public string Nome { get; set; }
        public string Campanha { get; set; }
        public string Personalidade { get; set; }
        public string Raca { get; set; }
        public string Ocupacao { get; set; }
        public string Estilo { get; set; }
    }

    public class EquipamentoPlanilha
    {
        public int Pente { get; set; }
        public string Item { get; set; }
        public int Quantidade { get; set; }
    }

    public class TalentoPlanilha
    {
        public int Valor { get; set; }
        public string Descricao { get; set; }        
    }

    public class PrecedentePlanilha
    {
        public int Valor { get; set; }
        public string Descricao { get; set; }
    }

    public class CapacidadePlanilha
    {
        public int DefesaFisica { get; set; }

        public int DefesaMental { get; set; }

        public int Deslocamento { get; set; }

        public int Carga { get; set; }

        public int Subturno { get; set; }

        public int IndiceProtecao { get; set; }

        public int ModificadorIniciativa { get; set; }
    }

    public class SaudePlanilha
    {
        public int Nivel
        {
            get;
            set;
        }

        public string Estado { get; set; }

        public int Penalidade
        {
            get;
            set;
        }
    }

    public class BarraEnergiaPlanilha
    {
        public int Vitalidade
        {
            get;
            set
            {
                if (value > 10)
                {
                    Vitalidade = 10;
                }
                else if (value < 0)
                {
                    Vitalidade = 0;
                }
                else
                {
                    Vitalidade = value;
                }
            }
        }

        public int EnergiaVital
        {
            get;
            set
            {
                if (value > 10)
                {
                    EnergiaVital = 10;
                }
                else if (value < 0)
                {
                    EnergiaVital = 0;
                }
                else
                {
                    EnergiaVital = value;
                }
            }
        }

        public int Corrupcao
        {
            get;
            set
            {
                if (value > 10)
                {
                    Corrupcao = 10;
                }
                else if (value < 0)
                {
                    Corrupcao = 0;
                }
                else
                {
                    Corrupcao = value;
                }
            }
        }

    }
}
