using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Grafos_V2
{
    
    
    public class Vertice
    {

        string nomeCidade;
        ListaRotas rotasAdjacentes;


        public Vertice()
        {
            rotasAdjacentes = new ListaRotas();
        }

        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }

            set
            {
                nomeCidade = value;
            }
        }

        public ListaRotas RotasAdjacentes
        {
            get
            {
                return rotasAdjacentes;
            }

            set
            {
                rotasAdjacentes = value;
            }
        }
    }
}
