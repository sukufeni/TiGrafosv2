using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Grafos_V2
{
    public class NoRotasAdj
    {
        ArestaRotas Aresta;
        NoRotasAdj prox;

        public NoRotasAdj(ArestaRotas aR)
        {
            this.Aresta = new ArestaRotas(0,new DateTime(),new Vertice());
            this.Aresta = aR;
        }
        public NoRotasAdj Prox
        {
            get           {                return prox;            }

            set            {                prox = value;            }
        }

        internal ArestaRotas Aresta1
        {
            get
            {                return Aresta;            }

            set
            {                Aresta = value;            }
        }
    }
    public class ListaRotas
    {
        NoRotasAdj prim;
        NoRotasAdj ult;

        public ListaRotas()
        {
            prim = new NoRotasAdj(new ArestaRotas(0,new DateTime(),new Vertice()));
            ult = new NoRotasAdj(new ArestaRotas(0, new DateTime(), new Vertice()));
            ult = prim;
        }

        public void Insert(ArestaRotas A)
        {
            NoRotasAdj n = new NoRotasAdj(A);
            this.ult.Prox = n;
            ult = n;
        }
        public double [,] preencheDistancia(int tamanhoRotas)
        {
            ListaRotas aux = new ListaRotas();
            Vertice v = new Vertice();
            v = aux.prim.Aresta1.VerticeAdjacenteRota;
            double [,] distancias = new double[tamanhoRotas,tamanhoRotas];
            while (v != null)
            {

            }

            return distancias;
        }


        public Vertice pesquisa(string nome)
        {
            NoRotasAdj aux = new NoRotasAdj(new ArestaRotas(0, new DateTime(), new Vertice()));
            while(aux.Prox != null)
            {
                if(aux.Prox.Aresta1.NomeOrigem == nome)
                {
                    return aux.Aresta1.VerticeAdjacenteRota;
                }

                aux = aux.Prox;
            }

            return null;
        }
    }
}
