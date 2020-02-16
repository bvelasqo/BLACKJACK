using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Baraja
    {
        Carta[] cartas = new Carta[52];
        public int posicionActual;
        Random r = new Random();
        public Baraja()
        {
            crearCartas();
        }

        public void crearCartas()
        {
            String numeros = "A123456789JQK";
            String simbolos = "TDCP";
            int posicionNuevaCarta=-1;
            for (int i = 0; i < simbolos.Length; i++)
            {
                for (int j = 0; j < numeros.Length; j++)
                {
                    posicionNuevaCarta++;
                    Carta nuevaCarta = new Carta();
                    nuevaCarta.Simbolo = simbolos[i];
                    nuevaCarta.Numero = numeros[j];
                    this.cartas[posicionNuevaCarta] = nuevaCarta;
                }
            }
        }
        public Carta darCarta()
        {
            posicionActual = r.Next(51);
            return cartas[posicionActual];
        }
    }
}
