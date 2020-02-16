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
    public partial class Form1 : Form
    {
        public Char tipoDeJuego;
        public long apuesta;
        public Jugador jugador1 = new Jugador();
        public Jugador jugador2=new Jugador();
        long apuesta1 = 0;
        long apuesta2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void setApuesta1(String d)
        {
            txtApuesta1.Text = d;
        }
        public void setApuesta2(String d)
        {
            txtApuesta2.Text = d;
        }
        public void setApuesta1c(String d)
        {
            txtApuesta1c.Text = d;
        }
        public void setApuesta2c(String d)
        {
            txtApuesta2c.Text = d;
        }
        public long getTotalApuestas()
        {
            apuesta1 = Convert.ToInt64(txtApuesta1.Text);
            apuesta2 = Convert.ToInt64(txtApuesta2.Text);
            apuesta = apuesta1 + apuesta2;
            return apuesta;
        }
        public long getTotalApuestascomputador()
        {
            apuesta1 = Convert.ToInt64(txtApuesta1c.Text);
            apuesta2 = Convert.ToInt64(txtApuesta2c.Text);
            apuesta = apuesta1 + apuesta2;
            return apuesta;
        }

        private void btn2Jugadores_Click(object sender, EventArgs e)
        {
            if (txtApuesta1.Text == "" || txtApuesta2.Text == "")
                
            {
                MessageBox.Show("Debe ingresar el valor de la apuesta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if((Convert.ToInt64(txtApuesta1.Text)) > 100000 || (Convert.ToInt64(txtApuesta2.Text)) > 100000)
            {
                MessageBox.Show("El valor de la apuesta no puede superar los 100.000 pesos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApuesta1.Text = "";
                txtApuesta2.Text = "";
            }
            else 
            {
                tipoDeJuego = '2';
                Tablero tablero = new Tablero(this);
                tablero.Show();
                this.Hide();

            }
              
        }

        private void btn1jugador_Click(object sender, EventArgs e)
        {
            if (txtApuesta1c.Text == "" )

            {
                MessageBox.Show("Debe ingresar el valor de la apuesta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((Convert.ToInt64(txtApuesta1c.Text)) > 100000 )
            {
                MessageBox.Show("El valor de la apuesta no puede superar los 100.000 pesos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApuesta1c.Text = "";
            }
            else 
            {
                tipoDeJuego = '1';
                Tablero tablero = new Tablero(this);
                tablero.Show();
                this.Hide();

            }


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            txtApuesta2c.Text = r.Next(0, 100001).ToString();
        }

        private void txtApuesta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
                    
            }
        }

        private void txtApuesta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)||Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;

            }
        }

        private void txtApuesta1c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;

            }
        }

        private void txtApuesta2c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;

            }
        }
    }
}
