using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Carta
    {
        private char numero;
        private char simbolo;

        public char Numero { get => numero; set => numero = value; }
        public char Simbolo { get => simbolo; set => simbolo = value; }

        public int valor(Boolean PuntajeMayor) {
            if (this.numero == 'J' || this.numero == 'Q' || this.numero == 'K') return 10;
            else if (this.numero == 'A')
            {
                if (PuntajeMayor) return 1;
                else return 11;
            }
            else return int.Parse(this.numero + "");
        }
        public string cartaCompleta()
        {
            return this.numero + "" + this.simbolo;
        }
    }
}
