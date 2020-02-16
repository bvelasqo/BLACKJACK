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
    public partial class ReplicaForm : Form
    {
        public Char tipoDeJuego;
        long apuesta1 = 0;
        long apuesta2 = 0;
        long total = 0;
        Tablero tablero;
        Form1 form;
        public ReplicaForm(Tablero tablero, Form1 form)
        {
            this.form = form;
            this.tablero = tablero;
            InitializeComponent();
            if (tablero.type){
                txtApuesta1.Enabled = false;
                txtApuesta2.Enabled = false;
                btn2Jugadores.Enabled = false;
            }
            else
            {
                txtApuesta1c.Enabled = false;
                txtApuesta2c.Enabled = false;
                btn1jugador.Enabled = false;
            }
        }

        public long getTotalApuestas()
        {
            apuesta1 = Convert.ToInt32(txtApuesta1.Text);
            apuesta2 = Convert.ToInt32(txtApuesta2.Text);
            total= apuesta1 + apuesta2;
            return total;
        }
        public long getTotalApuestascomputador()
        {
            apuesta1 = Convert.ToInt32(txtApuesta1c.Text);
            apuesta2 = Convert.ToInt32(txtApuesta2c.Text);
            total = apuesta1 + apuesta2;
            return total;
        }
        private void btn2Jugadores_Click(object sender, EventArgs e)
        {
            if (txtApuesta1.Text == "" || txtApuesta2.Text == "")

            {
                MessageBox.Show("Debe ingresar el valor de la apuesta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((Convert.ToInt64(txtApuesta1.Text)) > 100000 || (Convert.ToInt64(txtApuesta2.Text)) > 100000)
            {
                MessageBox.Show("El valor de la apuesta no puede superar los 100.000 pesos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApuesta1.Text = "";
                txtApuesta2.Text = "";
            }
            else
            {
                tipoDeJuego = '2';
                form.setApuesta1(txtApuesta1.Text);
                form.setApuesta2(txtApuesta2.Text);
                tablero = new Tablero(form);
                tablero.Show();
                this.Close();
            }
        }
        private void btn1jugador_Click(object sender, EventArgs e)
        {
            if (txtApuesta1c.Text == "")
            {
                MessageBox.Show("Debe ingresar el valor de la apuesta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((Convert.ToInt64(txtApuesta1c.Text)) > 100000)
            {
                MessageBox.Show("El valor de la apuesta no puede superar los 100.000 pesos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApuesta1c.Text = "";
            }
            else
            {
                tipoDeJuego = '1';
                form.setApuesta1c(txtApuesta1c.Text);
                form.setApuesta2c(txtApuesta2c.Text);
                tablero = new Tablero(form);
                tablero.Show();
                this.Close();
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
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
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
            if (Char.IsDigit(e.KeyChar))
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
