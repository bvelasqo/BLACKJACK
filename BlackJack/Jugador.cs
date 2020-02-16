using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Jugador
    {
        public List<Carta> mano = new List<Carta>();
        public long total = 0, puntaje = 0, triunfos = 0, dinero = 0;
        public void agregarCarta(Carta c)
        {
            mano.Add(c);
            if(puntaje>10&&c.Numero=='A') puntaje += c.valor(true);
            else puntaje += c.valor(false);
        }
        public void VolverAEmpezar()
        {
            puntaje = 0;
            mano.RemoveRange(0,mano.Count);
        }
        public void ganar(long apuesta)
        {
            triunfos++;
            total = puntaje;
            puntaje = 0;
            if (triunfos >= 2)
            {
                this.total *= 3;
                this.dinero = (this.dinero*3)+apuesta;
            }
            else dinero = apuesta;
        }
    }
}
