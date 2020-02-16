using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Computadora
    {
        Jugador jugadorContrario;
        public Jugador computador;
        public Computadora(Jugador jugador1, Jugador jugador2)
        {
            this.jugadorContrario = jugador1;
            this.computador = jugador2;
        }
        public Boolean sumaMayor()
        {
            if (computador.puntaje > 12 && jugadorContrario.puntaje < computador.puntaje) return true;
            else return false;
        }
    }
}