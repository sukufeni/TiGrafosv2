using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TI_Grafos_V2
{
    class Grafo
    {
        ListaVertices Vertices;

        public Grafo()
        {
            new ListaVertices();
        }

        public ListaVertices Vertices1
        {
            get
            {                return Vertices;            }

            set
            {                Vertices = value;            }
        }
    }
}
