namespace BlackJack
{
    partial class ReplicaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplicaForm));
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lblApuestaj1 = new System.Windows.Forms.Label();
            this.lblApuestaj2 = new System.Windows.Forms.Label();
            this.lblApuestaj = new System.Windows.Forms.Label();
            this.lblApuestaC = new System.Windows.Forms.Label();
            this.txtApuesta1 = new System.Windows.Forms.TextBox();
            this.txtApuesta2 = new System.Windows.Forms.TextBox();
            this.txtApuesta1c = new System.Windows.Forms.TextBox();
            this.txtApuesta2c = new System.Windows.Forms.TextBox();
            this.btn2Jugadores = new System.Windows.Forms.Button();
            this.btn1jugador = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtTitulo.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(0, 0);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTitulo.Size = new System.Drawing.Size(304, 57);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.Text = "BLACKJACK";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApuestaj1
            // 
            this.lblApuestaj1.AutoSize = true;
            this.lblApuestaj1.BackColor = System.Drawing.Color.Transparent;
            this.lblApuestaj1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuestaj1.Location = new System.Drawing.Point(4, 58);
            this.lblApuestaj1.Name = "lblApuestaj1";
            this.lblApuestaj1.Size = new System.Drawing.Size(170, 24);
            this.lblApuestaj1.TabIndex = 1;
            this.lblApuestaj1.Text = "Apuesta jugador 1:";
            // 
            // lblApuestaj2
            // 
            this.lblApuestaj2.AutoSize = true;
            this.lblApuestaj2.BackColor = System.Drawing.Color.Transparent;
            this.lblApuestaj2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuestaj2.Location = new System.Drawing.Point(180, 58);
            this.lblApuestaj2.Name = "lblApuestaj2";
            this.lblApuestaj2.Size = new System.Drawing.Size(172, 24);
            this.lblApuestaj2.TabIndex = 2;
            this.lblApuestaj2.Text = "Apuesta jugador 2:";
            // 
            // lblApuestaj
            // 
            this.lblApuestaj.AutoSize = true;
            this.lblApuestaj.BackColor = System.Drawing.Color.Transparent;
            this.lblApuestaj.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuestaj.Location = new System.Drawing.Point(6, 183);
            this.lblApuestaj.Name = "lblApuestaj";
            this.lblApuestaj.Size = new System.Drawing.Size(162, 24);
            this.lblApuestaj.TabIndex = 3;
            this.lblApuestaj.Text = "Apuesta jugador :";
            // 
            // lblApuestaC
            // 
            this.lblApuestaC.AutoSize = true;
            this.lblApuestaC.BackColor = System.Drawing.Color.Transparent;
            this.lblApuestaC.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApuestaC.Location = new System.Drawing.Point(174, 183);
            this.lblApuestaC.Name = "lblApuestaC";
            this.lblApuestaC.Size = new System.Drawing.Size(193, 24);
            this.lblApuestaC.TabIndex = 4;
            this.lblApuestaC.Text = "Apuesta computador:";
            // 
            // txtApuesta1
            // 
            this.txtApuesta1.BackColor = System.Drawing.Color.Black;
            this.txtApuesta1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApuesta1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApuesta1.ForeColor = System.Drawing.Color.White;
            this.txtApuesta1.Location = new System.Drawing.Point(28, 102);
            this.txtApuesta1.Name = "txtApuesta1";
            this.txtApuesta1.Size = new System.Drawing.Size(119, 15);
            this.txtApuesta1.TabIndex = 5;
            this.txtApuesta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApuesta1_KeyPress);
            // 
            // txtApuesta2
            // 
            this.txtApuesta2.BackColor = System.Drawing.Color.Black;
            this.txtApuesta2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApuesta2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApuesta2.ForeColor = System.Drawing.Color.White;
            this.txtApuesta2.Location = new System.Drawing.Point(194, 102);
            this.txtApuesta2.Name = "txtApuesta2";
            this.txtApuesta2.Size = new System.Drawing.Size(118, 15);
            this.txtApuesta2.TabIndex = 6;
            this.txtApuesta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApuesta2_KeyPress);
            // 
            // txtApuesta1c
            // 
            this.txtApuesta1c.BackColor = System.Drawing.Color.Black;
            this.txtApuesta1c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApuesta1c.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApuesta1c.ForeColor = System.Drawing.Color.White;
            this.txtApuesta1c.Location = new System.Drawing.Point(28, 224);
            this.txtApuesta1c.Name = "txtApuesta1c";
            this.txtApuesta1c.Size = new System.Drawing.Size(119, 15);
            this.txtApuesta1c.TabIndex = 7;
            this.txtApuesta1c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApuesta1c_KeyPress);
            // 
            // txtApuesta2c
            // 
            this.txtApuesta2c.BackColor = System.Drawing.Color.Black;
            this.txtApuesta2c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApuesta2c.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApuesta2c.ForeColor = System.Drawing.Color.White;
            this.txtApuesta2c.Location = new System.Drawing.Point(194, 224);
            this.txtApuesta2c.Name = "txtApuesta2c";
            this.txtApuesta2c.Size = new System.Drawing.Size(118, 15);
            this.txtApuesta2c.TabIndex = 8;
            this.txtApuesta2c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApuesta2c_KeyPress);
            // 
            // btn2Jugadores
            // 
            this.btn2Jugadores.BackColor = System.Drawing.Color.Transparent;
            this.btn2Jugadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2Jugadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Jugadores.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Jugadores.Location = new System.Drawing.Point(90, 132);
            this.btn2Jugadores.Name = "btn2Jugadores";
            this.btn2Jugadores.Size = new System.Drawing.Size(154, 37);
            this.btn2Jugadores.TabIndex = 10;
            this.btn2Jugadores.Text = "2 Jugadores";
            this.btn2Jugadores.UseVisualStyleBackColor = false;
            this.btn2Jugadores.Click += new System.EventHandler(this.btn2Jugadores_Click);
            // 
            // btn1jugador
            // 
            this.btn1jugador.BackColor = System.Drawing.Color.Transparent;
            this.btn1jugador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1jugador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1jugador.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1jugador.Location = new System.Drawing.Point(90, 255);
            this.btn1jugador.Name = "btn1jugador";
            this.btn1jugador.Size = new System.Drawing.Size(154, 37);
            this.btn1jugador.TabIndex = 11;
            this.btn1jugador.Text = "1 Jugador";
            this.btn1jugador.UseVisualStyleBackColor = false;
            this.btn1jugador.Click += new System.EventHandler(this.btn1jugador_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Location = new System.Drawing.Point(318, 222);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(18, 19);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ReplicaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 333);
            this.Controls.Add(this.btn1jugador);
            this.Controls.Add(this.btn2Jugadores);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtApuesta2c);
            this.Controls.Add(this.txtApuesta1c);
            this.Controls.Add(this.txtApuesta2);
            this.Controls.Add(this.txtApuesta1);
            this.Controls.Add(this.lblApuestaC);
            this.Controls.Add(this.lblApuestaj);
            this.Controls.Add(this.lblApuestaj2);
            this.Controls.Add(this.lblApuestaj1);
            this.Controls.Add(this.txtTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplicaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lblApuestaj1;
        private System.Windows.Forms.Label lblApuestaj2;
        private System.Windows.Forms.Label lblApuestaj;
        private System.Windows.Forms.Label lblApuestaC;
        private System.Windows.Forms.TextBox txtApuesta1;
        private System.Windows.Forms.TextBox txtApuesta2;
        private System.Windows.Forms.TextBox txtApuesta1c;
        private System.Windows.Forms.TextBox txtApuesta2c;
        private System.Windows.Forms.Button btn2Jugadores;
        private System.Windows.Forms.Button btn1jugador;
        private System.Windows.Forms.Button btnActualizar;
    }
}

