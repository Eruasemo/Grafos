using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Grafo
    {
        private int vertices;
        private bool direccion;
        LinkedList<int>[] adyacencia;

        public Grafo(int vertices, bool direccion)
        {
            adyacencia = new LinkedList<int>[vertices];
            this.vertices = vertices;
            this.direccion = direccion;

            for (int i = 0; i<adyacencia.Length; i++)
            {
                adyacencia[i] = new LinkedList<int>();
               
            }
        }

        public void agregarArco(int v, int w)
        {
            adyacencia[v].AddLast(w);
            if (!direccion)
            {
                adyacencia[w].AddLast(v);
            }
        }

        private void BPhasta(int v, bool[] visita)
        {
            visita[v] = true;
            Console.Write(v + " ");
            LinkedList<int> lista = adyacencia[v];
            foreach(var valor in lista)
            {
                if (!visita[valor])
                {
                    BPhasta(valor, visita);
                }
            }
        }
        
        public void busquedaProfunda(int v)
        {
            bool[] visita = new bool[vertices];
            for(int i=0; i<vertices; i++)
            {
                visita[i] = false;
            }

            BPhasta(v, visita);
            Console.WriteLine();
        }

        public void busquedaAncha(int s)
        {
            bool[] visita = new bool[vertices];
            for (int i = 0; i < vertices; i++)
            {
                visita[i] = false;
            }

            Queue<int> cola = new Queue<int>();
            visita[s] = true;
            cola.Enqueue(s);
            while (cola.Any())
            {
                s = cola.Dequeue();
                Console.Write(s + " ");
                

                LinkedList<int> lista = adyacencia[s];

                foreach(var valor in lista)
                {
                    if (!visita[valor])
                    {
                        visita[valor] = true;
                        cola.Enqueue(valor);
                    }
                }

            }
        }

    }
}
