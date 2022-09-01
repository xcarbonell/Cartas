using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cartas
{
    public class Carta
    {
        int numero;
        int palo;
        string[] palos = { "Oros", "Copas", "Bastos", "Espadas" };
        public Carta()
        {
            numero = 0;
            palo = 0;

        }

        public Carta(int n, int p)
        {
            numero = n;
            palo = p;
        }

        public int getNumero()
        {
            return this.numero;
        }

        public void setNumero(int n)
        {
            this.numero = n;
        }

        public int getPalo()
        {
            return this.palo;
        }

        public void setPalo(int p)
        {
            this.palo = p;
        }

        public override string ToString()
        {
            return numero + " de " + palos[palo];
        }
    }
}
