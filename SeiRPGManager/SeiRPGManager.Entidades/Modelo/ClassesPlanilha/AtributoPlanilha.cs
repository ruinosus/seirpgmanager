using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Entidades.Modelo.ClassesPlanilha
{
    public static class AtributoPlanilha
    {
        public class Fisico
        {
            public Fisico()
            {
                Forca = 1;
                Destreza = 1;
                Resistencia = 1;
            }

            public int Forca
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Forca = 1;
                    }
                    else if (value > 10)
                    {
                        Forca = 10;
                    }
                    else
                    {
                        Forca = value;
                    }
                }
            }

            public int Destreza
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Destreza = 1;
                    }
                    else if (value > 10)
                    {
                        Destreza = 10;
                    }
                    else
                    {
                        Destreza = value;
                    }
                }
            }

            public int Resistencia
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Resistencia = 1;
                    }
                    else if (value > 10)
                    {
                        Resistencia = 10;
                    }
                    else
                    {
                        Resistencia = value;
                    }
                }
            }
        }

        public class Mental
        {
            public Mental()
            {
                Intelecto = 1;
                Influencia = 1;
                Percepcao = 1;
            }

            public int Intelecto
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Intelecto = 1;
                    }
                    else if (value > 10)
                    {
                        Intelecto = 10;
                    }
                    else
                    {
                        Intelecto = value;
                    }
                }
            }

            public int Influencia
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Influencia = 1;
                    }
                    else if (value > 10)
                    {
                        Influencia = 10;
                    }
                    else
                    {
                        Influencia = value;
                    }
                }
            }

            public int Percepcao
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Percepcao = 1;
                    }
                    else if (value > 10)
                    {
                        Percepcao = 10;
                    }
                    else
                    {
                        Percepcao = value;
                    }
                }
            }
        }

        public class Sobrenatural
        {
            public Sobrenatural()
            {
                Determinacao = 1;
                Intuicao = 1;
                Imunidade = 1;
            }

            public int Determinacao
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Determinacao = 1;
                    }
                    else if (value > 10)
                    {
                        Determinacao = 10;
                    }
                    else
                    {
                        Determinacao = value;
                    }
                }
            }

            public int Intuicao
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Intuicao = 1;
                    }
                    else if (value > 10)
                    {
                        Intuicao = 10;
                    }
                    else
                    {
                        Intuicao = value;
                    }
                }
            }

            public int Imunidade
            {
                get;
                set
                {
                    if (value < 0)
                    {
                        Imunidade = 1;
                    }
                    else if (value > 10)
                    {
                        Imunidade = 10;
                    }
                    else
                    {
                        Imunidade = value;
                    }
                }
            }
        }
    }
}
