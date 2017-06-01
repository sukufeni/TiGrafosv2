using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Grafos_V2
{
    class ArestaVoo
    {
        Vertice VerticeAdjacenteVoo;
        List<Horario> HorariosVoos;
        //string nomeOrigem;
        public ArestaVoo(string nomeOrigem)
        {
            VerticeAdjacenteVoo = new Vertice();
            HorariosVoos = new List<Horario>();
           
        }

        public void AdicionarHorario(Horario horario)
        {
            this.HorariosVoos.Add(horario);
        }

        
    }
}
