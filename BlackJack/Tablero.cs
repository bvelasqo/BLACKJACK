using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Tablero : Form
    {
        
        Form1 form;
        Jugador jugador1;
        Jugador jugador2;
        Computadora computadora;
        Baraja baraja = new Baraja();
        int posicion1 = 0;
        long apuesta;
        Boolean ganaron = false;
        int posicion2 = 0;

        public Boolean type;
        public Tablero(Form1 form)
        {
            this.jugador1 = form.jugador1;
            this.jugador2 = form.jugador2;
            this.form = form;
            InitializeComponent();
            type=TipoDeJuego();
            btnPedirCarta2.Enabled = false;
            btnPasar2.Enabled = false;
            jugador1.agregarCarta(baraja.darCarta());
            jugador1.agregarCarta(baraja.darCarta());
            jugador2.agregarCarta(baraja.darCarta());
            jugador2.agregarCarta(baraja.darCarta());
            validacionNum(true);
            validacionNum(false);
            validacionImg(true);
            validacionImg(false);
            puntaje();
        }
        public void puntaje()
        {
            lblPuntaje1.Text = "Puntaje: " + jugador1.puntaje;
            lblPuntaje2.Text = "Puntaje: " + jugador2.puntaje;
            lblDinero1.Text = "Dinero: " + jugador1.dinero;
            lblDinero2.Text = "Dinero: " + jugador2.dinero;
            lblTotal1.Text = "Total: " + jugador1.total;
            lblTotal2.Text = "Total: " + jugador2.total;
        }
        public void validacionNum(Boolean a)
        {
            if (a)
            {
                lblN11.Text = jugador1.mano.ElementAt(posicion1).Numero + "";
                lbl12.Text = jugador1.mano.ElementAt(posicion1).Numero + "";
            }
            else
            {
                lbl21.Text = jugador2.mano.ElementAt(posicion2).Numero + "";
                lbl22.Text = jugador2.mano.ElementAt(posicion2).Numero + "";
            }
        }
        public void validacionImg(Boolean a)
        {
            if (a)
            {
                Char simbolo = jugador1.mano.ElementAt(posicion1).Simbolo;
                switch (simbolo){
                    case 'C':
                        imagen1.ImageIndex = 0;
                        break;
                    case 'D':
                        imagen1.ImageIndex = 3;
                        break;
                    case 'T':
                        imagen1.ImageIndex = 2;
                        break;
                    case 'P':
                        imagen1.ImageIndex = 1;
                        break;
                }
            }
            else
            {
                Char simbolo = jugador2.mano.ElementAt(posicion2).Simbolo;
                switch (simbolo)
                {
                    case 'C':
                        imagen2.ImageIndex = 0;
                        break;
                    case 'D':
                        imagen2.ImageIndex = 3;
                        break;
                    case 'T':
                        imagen2.ImageIndex = 2;
                        break;
                    case 'P':
                        imagen2.ImageIndex = 1;
                        break;
                }
            }
        }
        private Boolean TipoDeJuego()
        {
            if (form.tipoDeJuego == '1')
            {
                computadora = new Computadora(jugador1, jugador2);
                apuesta = form.getTotalApuestascomputador();
                return true;
            }
            else
            {
                apuesta = form.getTotalApuestas();
                return false;
            }
        }
        private void btnPasar1_Click(object sender, EventArgs e)
        {
            if (type)
            {
                while (computadora.sumaMayor() == false && !ganaron)
                {
                    btnPedirCarta2_Click(this, e);

                }
                if (!ganaron) btnPasar2_Click(this, e);
            }
            else
            {
                btnPasar1.Enabled = false;
                btnPasar2.Enabled = true;
                btnPedirCarta1.Enabled = false;
                btnPedirCarta2.Enabled = true;
            }
        }
        private void btnPasar2_Click(object sender, EventArgs e)
        {
            if (jugador1.puntaje > jugador2.puntaje)
            {
                jugador1.ganar(apuesta);
                if (MessageBox.Show("El jugador 1 ha ganado! \n ¿Desea volver a jugar?", "Felicitaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    jugador1.VolverAEmpezar();
                    jugador2.VolverAEmpezar();
                    ganaron = true;
                    ReplicaForm r = new ReplicaForm(this,form);
                    r.Show();
                    puntaje();

                }
                else
                {
                    form.Close();
                }
                this.Close();
            }
            else if (jugador1.puntaje < jugador2.puntaje)
            {
                jugador2.ganar(apuesta);
                if (MessageBox.Show("El jugador 2 ha ganado! \n ¿Desea volver a jugar?", "Felicitaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ganaron = true;
                    jugador1.VolverAEmpezar();
                    jugador2.VolverAEmpezar();
                    ReplicaForm r = new ReplicaForm(this, form);
                    r.Show();
                    puntaje();

                }
                else
                {
                    form.Close();

                }
                this.Close();

            }
            else {
                if (MessageBox.Show("Empataron \n ¿Desea volver a jugar?", "Empate", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ganaron = true;
                    jugador1.VolverAEmpezar();
                    jugador2.VolverAEmpezar();
                    ReplicaForm r = new ReplicaForm(this, form);
                    r.Show();
                    puntaje();

                }
                else
                {
                    form.Close();

                }
                this.Close();

            }
        }
        private void btnPedirCarta1_Click(object sender, EventArgs e)
        {
            
            jugador1.agregarCarta(baraja.darCarta());
            puntaje();
            if (jugador1.puntaje > 21)
            {
                jugador2.ganar(apuesta);
                if (MessageBox.Show("El jugador 2 ha ganado! \n ¿Desea volver a jugar?", "Felicitaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ganaron = true;
                    jugador1.VolverAEmpezar();
                    jugador2.VolverAEmpezar();
                    ReplicaForm r = new ReplicaForm(this, form);
                    r.Show();
                    puntaje();

                }
                else
                {
                    form.Close();

                }
                this.Close();

            }
            if (jugador1.puntaje == 21)
            {
                jugador1.ganar(apuesta);
                if (MessageBox.Show("El jugador 1 ha ganado! \n ¿Desea volver a jugar?", "Felicitaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ganaron = true;
                    jugador1.VolverAEmpezar();
                    jugador2.VolverAEmpezar();
                    ReplicaForm r = new ReplicaForm(this, form);
                    r.Show();
                    puntaje();

                }
                else
                {
                    form.Close();

                }
                this.Close();

            }

        }
        private void btnPedirCarta2_Click(object sender, EventArgs e)
        {
            jugador2.agregarCarta(baraja.darCarta());
            puntaje();
            if (jugador2.puntaje > 21)
            {
                jugador1.ganar(apuesta);
                if (MessageBox.Show("El jugador 1 ha ganado! \n ¿Desea volver a jugar?", "Felicitaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ganaron = true;
                    jugador1.VolverAEmpezar();
                    jugador2.VolverAEmpezar();
                    ReplicaForm r = new ReplicaForm(this, form);
                    r.Show();
                    puntaje();

                }
                else
                {
                    form.Close();

                }
                this.Close();

            }
            if (jugador2.puntaje == 21)
            {
                jugador2.ganar(apuesta);
                if (MessageBox.Show("El jugador 2 ha ganado! \n ¿Desea volver a jugar?", "Felicitaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    ganaron = true;
                    jugador1.VolverAEmpezar();
                    jugador2.VolverAEmpezar();
                    ReplicaForm r = new ReplicaForm(this, form);
                    r.Show();
                    puntaje();
                    
                }
                else
                {
                    form.Close();

                }
                this.Close();

            }
        }
        private void btnBack1_Click(object sender, EventArgs e)
        {
            try
            {
                posicion1++;
                validacionNum(true);
                validacionImg(true);
            }
            catch
            {
                posicion1--;
            }
        }
        private void btnNext1_Click(object sender, EventArgs e)
        {
            try
            {
                posicion1--;
                validacionNum(true);
                validacionImg(true);
            }
            catch
            {
                posicion1++;

            }
        }
        private void btnNext2_Click(object sender, EventArgs e)
        {
            try
            {
                posicion2++;
                validacionNum(false);
                validacionImg(false);
            }
            catch
            {
                posicion2--;
            }
        }
        private void btnBack2_Click(object sender, EventArgs e)
        {
            try
            {
                posicion2--;
                validacionNum(false);
                validacionImg(false);
            }
            catch
            {
                posicion2++;

            }
        }
    }
}
