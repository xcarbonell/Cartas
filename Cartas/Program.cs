using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartas
{
    class Program
    {
        static void Main(string[] args)
        {
            Baraja baraja = new Baraja();
            Console.WriteLine("Numero cartas:");
            baraja.NumeroCartas();
            Console.WriteLine("Roba carta:");
            baraja.RobaCarta();
            Console.WriteLine("Teclea una carta que quieras coger:");
            baraja.CogeCarta(int.Parse(Console.ReadLine()));
            Console.WriteLine("Carta aleatoria:");
            baraja.CogeCartaAlAzar();
            Console.WriteLine("Listado de cartas:");
            baraja.ToString();
            Console.WriteLine("Listado de cartas aleatorias:");
            baraja.Barajar();
            Console.ReadLine();
        }
    }
}
