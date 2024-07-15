using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo grafo = new Grafo(7, true);
            grafo.agregarArco(0, 1);
            grafo.agregarArco(0, 2);
            grafo.agregarArco(0, 3);
            grafo.agregarArco(1, 0);
            grafo.agregarArco(1, 5);
            grafo.agregarArco(2, 5);
            grafo.agregarArco(3, 0);
            grafo.agregarArco(3, 4);
            grafo.agregarArco(4, 6);
            grafo.agregarArco(5, 1);
            grafo.agregarArco(6, 5);

            Console.WriteLine("Busqueda en profundidad desde vertice 0: ");
            grafo.busquedaProfunda(0);

            Console.WriteLine("Busqueda a lo ancho desde vertice 0: ");
            grafo.busquedaAncha(0);
        }
    }
}
