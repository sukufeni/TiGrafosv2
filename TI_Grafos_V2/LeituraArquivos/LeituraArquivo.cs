using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TI_Grafos_V2
{
    class LeituraDeArquivos

    {
        //Origem, Destino, Horasaida - VOO
        //Origem, Destino, tempo, distância - Rota

        string localRotas = @"C:/.../TI_Grafos_V2/rotas.txt";

       Grafo G = new Grafo();

        public void LerRota()
        {
            if (File.Exists(localRotas))
            {
                string Linha;
                var aquivo = new StreamReader(localRotas);

                

                while ((Linha = aquivo.ReadLine()) != null)
                {
                    string[] detalhes = Linha.Split('/');

                    Vertice v1 = new Vertice();
                   v1.NomeCidade = detalhes[0].ToUpper();
                    Vertice v2 = new Vertice();
                    v2.NomeCidade = detalhes[1].ToUpper();                   

                    if (G.Vertices1.Existe(v1.NomeCidade))
                    {
                        Vertice v = G.Vertices1.pesquisa(v1.NomeCidade);
                        v.RotasAdjacentes.Insert(new ArestaRotas(Convert.ToDouble(detalhes[3]), Convert.ToDateTime(detalhes[2]), v2));
                    }
                    else
                    {
                        v1.RotasAdjacentes.Insert(new ArestaRotas(Convert.ToDouble(detalhes[3]), Convert.ToDateTime(detalhes[2]), v2));
                        G.Vertices1.Insert(v1);                    
                        
                    }

                    if (G.Vertices1.Existe(v2.NomeCidade))
                    {
                        Vertice v = G.Vertices1.pesquisa(v2.NomeCidade);
                        v.RotasAdjacentes.Insert(new ArestaRotas(Convert.ToDouble(detalhes[3]), Convert.ToDateTime(detalhes[2]), v1));
                    }
                    else
                    {
                        v2.RotasAdjacentes.Insert(new ArestaRotas(Convert.ToDouble(detalhes[3]), Convert.ToDateTime(detalhes[2]), v1));
                        G.Vertices1.Insert(v2);
                    }


                }
            }

        }
    }
}
