using System;
using System.Collections.Generic;
using System.Linq;

namespace Cartas
{
    public class Baraja
    {
        List<Carta> baraja = new List<Carta>();
        Carta card;

        public Baraja()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Carta card = new Carta(j + 1, i);
                    baraja.Add(card);
                }
            }
        }

        //constructor

        public void NumeroCartas()
        {
            Console.WriteLine(baraja.Count);
        }

        public void RobaCarta()
        {
            Console.WriteLine("Primera carta: " + baraja[0].ToString());
            int numero = baraja[0].getNumero();
            int palo = baraja[0].getPalo();
            baraja.RemoveAt(0);
            baraja.Add(new Carta(numero, palo));
            Console.WriteLine("Ultima carta: " + baraja[47].ToString());
        }

        public void CogeCarta(int n)
        {
            Console.WriteLine("Carta escogida: " + baraja[n].ToString());
            int numero = baraja[n].getNumero();
            int palo = baraja[n].getPalo();
            baraja.RemoveAt(n);
            baraja.Add(new Carta(numero, palo));
            Console.WriteLine("Ultima carta: " + baraja[47].ToString());
        }

        public void CogeCartaAlAzar()
        {
            Random rand = new Random();
            int n = rand.Next(0, baraja.Count - 1);
            Console.WriteLine("Carta escogida: " + baraja[n].ToString());
        }

        public void ToString()
        {
            for (int i = 0; i < baraja.Count; i++)
            {
                Console.WriteLine("Carta: " + baraja[i].ToString());
            }
        }

        public void Barajar()
        {
            var rnd = new Random();
            var randomized = baraja.OrderBy(item => rnd.Next());

            foreach (var value in randomized)
            {
                Console.WriteLine(value);
            }
        }
    }
}
