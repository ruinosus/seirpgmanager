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
            get
            {
                return Valor;
            }
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
            get
            {
                return Valor;
            }
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
            get
            {
                return Valor;
            }
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
        public EspecializacaoPlanilha Salto { get; set; }
        public EspecializacaoPlanilha Corrida { get; set; }
        public EspecializacaoPlanilha Escalada { get; set; }
        public EspecializacaoPlanilha Natacao { get; set; }
        public EspecializacaoPlanilha Esporte { get; set; }
    }

    public class HabilitadorCombateProximo : HabilitadorPlanilha
    {
        public EspecializacaoPlanilha CombateDesarmado { get; set; }
        public EspecializacaoPlanilha Evasao { get; set; }
        public EspecializacaoPlanilha ArmBrancaCurta { get; set; }
        public EspecializacaoPlanilha ArmBrancaMedia { get; set; }
        public EspecializacaoPlanilha ArmBrancaLonga { get; set; }
    }

    public class HabilitadorCombateAfastado : HabilitadorPlanilha
    {
        public EspecializacaoPlanilha Armamento { get; set; }
        public EspecializacaoPlanilha ArmImpulso { get; set; }
        public EspecializacaoPlanilha ArmFogoLeve { get; set; }
        public EspecializacaoPlanilha ArmFogoMedia { get; set; }
        public EspecializacaoPlanilha ArmFogoPesada { get; set; }
    }

    public class HabilitadorInstrucao : HabilitadorPlanilha
    {
        public EspecializacaoPlanilha Medicina { get; set; }
        public EspecializacaoPlanilha Computacao { get; set; }
        public EspecializacaoPlanilha Linguistica { get; set; }
        public EspecializacaoPlanilha Conhecimento { get; set; }
        public EspecializacaoPlanilha Ocultismo { get; set; }
    }

    public class HabilitadorSocial : HabilitadorPlanilha
    {
        public EspecializacaoPlanilha Empatia { get; set; }
        public EspecializacaoPlanilha TratoAnimais { get; set; }
        public EspecializacaoPlanilha Labia { get; set; }
        public EspecializacaoPlanilha Malandragem { get; set; }
        public EspecializacaoPlanilha Performance { get; set; }
    }

    public class HabilitadorPerspicacia : HabilitadorPlanilha
    {
        public EspecializacaoPlanilha Investigacao { get; set; }
        public EspecializacaoPlanilha Furtividade { get; set; }
        public EspecializacaoPlanilha Prestidigitacao { get; set; }
        public EspecializacaoPlanilha Reparo { get; set; }
        public EspecializacaoPlanilha Subterfugio { get; set; }
    }

    public class HabilitadorSobrenatural : HabilitadorPlanilha
    {
        public EspecializacaoPlanilha Slot1 { get; set; }
        public EspecializacaoPlanilha Slot2 { get; set; }
        public EspecializacaoPlanilha Slot3 { get; set; }
        public EspecializacaoPlanilha Slot4 { get; set; }
        public EspecializacaoPlanilha Slot5 { get; set; }
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
        public int Tamanho { get; set; }
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
            get
            {
                return Vitalidade;
            }
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
            get
            {
                return EnergiaVital;
            }
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
            get
            {
                return Corrupcao;
            }
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
