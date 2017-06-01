using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Grafos_V2
{
    public class ArestaRotas
    {
        Vertice verticeRotaAdjacente;
        double distancia;
        DateTime tempo;
        string nomeOrigem;

       public Vertice VerticeAdjacenteRota
        {
            get
            {                return verticeRotaAdjacente;            }

            set
            {                verticeRotaAdjacente = value;            }
        }

        public double Distancia
        {
            get
            {                return distancia;            }

            set
            {                distancia = value;            }
        }

        public DateTime Tempo
        {
            get
            {                return tempo;            }

            set
            {                tempo = value;            }
        }

        public string NomeOrigem
        {
            get
            {                return nomeOrigem;            }

            set
            {                nomeOrigem = value;            }
        }

        public ArestaRotas(double distancia, DateTime tempo, Vertice Adjacente)
        {
            VerticeAdjacenteRota = new Vertice();
            VerticeAdjacenteRota = Adjacente;
            this.Distancia = distancia;
            this.NomeOrigem = nomeOrigem;
            this.Tempo = tempo;
        }
    }
}
