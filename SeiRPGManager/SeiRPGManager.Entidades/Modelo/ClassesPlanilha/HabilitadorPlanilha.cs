using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Entidades.Modelo.ClassesPlanilha
{
    public class HabilitadorPlanilha
    {
        public class Fisico
        {
            public class Atletico
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                #region Especializacoes Atletico

                public int Salto
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Salto = 0;
                        }
                        else if (Salto > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Salto = 3;
                        }
                        else
                        {
                            Salto = value;
                        }
                    }
                }
               
                public int Corrida
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Corrida = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Nivel = 3;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                public int Natacao
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Natacao = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Natacao = 3;
                        }
                        else
                        {
                            Natacao = value;
                        }
                    }
                }

                public int Escalada
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Escalada = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Escalada = 3;
                        }
                        else
                        {
                            Escalada = value;
                        }
                    }
                }

                public int Esporte
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Esporte = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Esporte = 3;
                        }
                        else
                        {
                            Esporte = value;
                        }
                    }
                }

                #endregion
            }

            public class CombateProximo
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                #region Especializacoes Combate Proximo

                public int CombateDesarmado
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            CombateDesarmado = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            CombateDesarmado = 3;
                        }
                        else
                        {
                            CombateDesarmado = value;
                        }
                    }
                }

                public int Evasao
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Evasao = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Evasao = 3;
                        }
                        else
                        {
                            Evasao = value;
                        }
                    }
                }

                public int ArmaBrancaCurta
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            ArmaBrancaCurta = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            ArmaBrancaCurta = 3;
                        }
                        else
                        {
                            ArmaBrancaCurta = value;
                        }
                    }
                }

                public int ArmaBrancaMedia
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            ArmaBrancaMedia = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            ArmaBrancaMedia = 3;
                        }
                        else
                        {
                            ArmaBrancaMedia = value;
                        }
                    }
                }

                public int ArmaBrancaPesada
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            ArmaBrancaPesada = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            ArmaBrancaPesada = 3;
                        }
                        else
                        {
                            ArmaBrancaPesada = value;
                        }
                    }
                }
                #endregion

            }

            public class CombateAfastado
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                #region Especializacoes Combate Afastado

                public int Armamento
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Armamento = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Armamento = 3;
                        }
                        else
                        {
                            Armamento = value;
                        }
                    }
                }

                public int ArmaImpulso
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            ArmaImpulso = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            ArmaImpulso = 3;
                        }
                        else
                        {
                            ArmaImpulso = value;
                        }
                    }
                }

                public int ArmaFogoLeve
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            ArmaFogoLeve = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            ArmaFogoLeve = 3;
                        }
                        else
                        {
                            ArmaFogoLeve = value;
                        }
                    }
                }

                public int ArmaFogoMedia
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            ArmaFogoMedia = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            ArmaFogoMedia = 3;
                        }
                        else
                        {
                            ArmaFogoMedia = value;
                        }
                    }
                }

                public int ArmaFogoPesada
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            ArmaFogoPesada = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            ArmaFogoPesada = 3;
                        }
                        else
                        {
                            ArmaFogoPesada = value;
                        }
                    }
                }

                #endregion

            }
        }

        public class Mental
        {
            public class Instrucao
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                #region Especializacoes Instrucao

                public int Medicina
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Medicina = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Medicina = 3;
                        }
                        else
                        {
                            Medicina = value;
                        }
                    }
                }

                public int Computacao
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Computacao = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Computacao = 3;
                        }
                        else
                        {
                            Computacao = value;
                        }
                    }
                }

                public int Conhecimento
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Conhecimento = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Conhecimento = 3;
                        }
                        else
                        {
                            Conhecimento = value;
                        }
                    }
                }

                public int Linguistica
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Linguistica = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Linguistica = 3;
                        }
                        else
                        {
                            Linguistica = value;
                        }
                    }
                }

                public int Ocultismo
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Ocultismo = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Ocultismo = 3;
                        }
                        else
                        {
                            Ocultismo = value;
                        }
                    }
                }
                #endregion

            }

            public class Social
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                #region Especializacoes Social

                public int Empatia
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Empatia = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Empatia = 3;
                        }
                        else
                        {
                            Empatia = value;
                        }
                    }
                }

                public int TratoAnimais
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            TratoAnimais = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            TratoAnimais = 3;
                        }
                        else
                        {
                            TratoAnimais = value;
                        }
                    }
                }

                public int Labia
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Labia = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Labia = 3;
                        }
                        else
                        {
                            Labia = value;
                        }
                    }
                }

                public int Malandragem
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Malandragem = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Malandragem = 3;
                        }
                        else
                        {
                            Malandragem = value;
                        }
                    }
                }

                public int Performance
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Performance = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Performance = 3;
                        }
                        else
                        {
                            Performance = value;
                        }
                    }
                }

                #endregion

            }

            public class Perspicacia
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                #region Especializacoes Perspicacia

                public int Investigacao
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Investigacao = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Investigacao = 3;
                        }
                        else
                        {
                            Investigacao = value;
                        }
                    }
                }

                public int Furtividade
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Furtividade = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Furtividade = 3;
                        }
                    }
                }

                public int Prestidigitacao
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Prestidigitacao = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Prestidigitacao = 3;
                        }
                        else
                        {
                            Investigacao = value;
                        }
                    }
                }

                public int Subterfugio
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Subterfugio = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Subterfugio = 3;
                        }
                        else
                        {
                            Subterfugio = value;
                        }
                    }
                }

                #endregion

            }
        }

        public class Sobrenatural
        {
            public class HabilitadorSlot1
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                public int Slot1
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot1 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot1 = 3;
                        }
                        else
                        {
                            Slot1 = value;
                        }
                    }
                }

                public int Slot2
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot2 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot2 = 3;
                        }
                        else
                        {
                            Slot2 = value;
                        }
                    }
                }

                public int Slot3
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot3 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot3 = 3;
                        }
                        else
                        {
                            Slot3 = value;
                        }
                    }
                }

                public int Slot4
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot4 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot4 = 3;
                        }
                        else
                        {
                            Slot4 = value;
                        }
                    }
                }

                public int Slot5
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot5 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot5 = 3;
                        }
                        else
                        {
                            Slot5 = value;
                        }
                    }
                }
            }

            public class HabilitadorSlot2
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                public int Slot1
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot1 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot1 = 3;
                        }
                        else
                        {
                            Slot1 = value;
                        }
                    }
                }

                public int Slot2
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot2 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot2 = 3;
                        }
                        else
                        {
                            Slot2 = value;
                        }
                    }
                }

                public int Slot3
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot3 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot3 = 3;
                        }
                        else
                        {
                            Slot3 = value;
                        }
                    }
                }

                public int Slot4
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot4 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot4 = 3;
                        }
                        else
                        {
                            Slot4 = value;
                        }
                    }
                }

                public int Slot5
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot5 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot5 = 3;
                        }
                        else
                        {
                            Slot5 = value;
                        }
                    }
                }

            }

            public class HabilitadorSlot3
            {
                public int Nivel
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Nivel = 1;
                        }
                        else if (value > 5)
                        {
                            Nivel = 5;
                        }
                        else
                        {
                            Nivel = value;
                        }
                    }
                }

                public int Slot1
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot1 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot1 = 3;
                        }
                        else
                        {
                            Slot1 = value;
                        }
                    }
                }

                public int Slot2
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot2 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot2 = 3;
                        }
                        else
                        {
                            Slot2 = value;
                        }
                    }
                }

                public int Slot3
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot3 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot3 = 3;
                        }
                        else
                        {
                            Slot3 = value;
                        }
                    }
                }

                public int Slot4
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot4 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot4 = 3;
                        }
                        else
                        {
                            Slot4 = value;
                        }
                    }
                }

                public int Slot5
                {
                    get;
                    set
                    {
                        if (value < 0)
                        {
                            Slot5 = 0;
                        }
                        else if (value > Nivel)
                        {
                            value = Nivel;
                        }
                        else if (value > 3)
                        {
                            Slot5 = 3;
                        }
                        else
                        {
                            Slot5 = value;
                        }
                    }
                }

            }
        }
    }
}
