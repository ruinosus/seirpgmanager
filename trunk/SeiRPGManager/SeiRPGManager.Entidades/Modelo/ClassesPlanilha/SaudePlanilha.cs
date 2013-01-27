using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeiRPGManager.Entidades.Modelo.ClassesPlanilha
{
    public class SaudePlanilha
    {
        public int Nivel
        {
            get;
            set
            {
                if (value == 0)
                {
                    Nivel = 1;
                }
                if (value > 5)
                {
                    Nivel = 5;
                }
                else
                {
                    Nivel = value;
                }
            }
        }

        public string Estado { get; set; }

        public int Penalidade
        {
            get;
            set
            {
                if (value > 0)
                {
                    Penalidade = 0;
                }
                if (value < -5)
                {
                    Penalidade = -5;
                }
                else
                {
                    Penalidade = value;
                }
            }
        }
    }
}
