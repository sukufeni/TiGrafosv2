using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Grafos_V2
{
    class No
    {
        Vertice V;
        No proximo;

        public Vertice V1
        {
            get
            {                return V;            }

            set
            {                V = value;            }
        }

        public No Proximo
        {
            get
            {                return proximo;            }

            set
            {                proximo = value;            }
        }

        public No()
        {
            V1 = new Vertice();
        }

    }
    class ListaVertices
    {
        No sentinela;
        No Ultimo;

        public ListaVertices()
        {
            sentinela = new No();
            Ultimo= new No();
            Ultimo = sentinela;
        }

        public void Insert(Vertice vertice)
        {
            vertice.NomeCidade.ToUpper();
            No n = new No();
            n.V1 = vertice;
            this.Ultimo.Proximo = n;
            Ultimo = n;
        }

        public bool Existe(string nomeAeroporto)
        {
            nomeAeroporto.ToUpper();

            No aux = new No();
            aux = this.sentinela;

            while(aux.Proximo != null)
            {
                if(aux.Proximo.V1.NomeCidade == nomeAeroporto)
                {
                    return true;
                }
            }

            return false;
        }

        public Vertice pesquisa(string nomeAeroporto)
        {
            nomeAeroporto.ToUpper();

            No aux = new No();
            aux = this.sentinela;

            while (aux.Proximo != null)
            {
                if (aux.Proximo.V1.NomeCidade == nomeAeroporto)
                {
                    return aux.Proximo.V1;
                }

                aux = aux.Proximo;
            }

            return null;
        }
    }
}
