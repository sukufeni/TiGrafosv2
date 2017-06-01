using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Grafos_V2
{
    class Horario
    {
        DateTime saida;
        DateTime chegada;

        public DateTime Saida
        {
            get
            {                return saida;            }

            set
            {                saida = value;            }
        }

        public DateTime Chegada
        {
            get
            {                return chegada;            }

            set
            {                chegada = value;            }
        }

        //Tem que converter string pra double
        public Horario()
        {

        }
    }
}
