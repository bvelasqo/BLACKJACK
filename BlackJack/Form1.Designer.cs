namespace BlackJack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTitulo = new System.Windows.Forms.Label();
            this.lblApuestaj1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApuesta1 = new System.Windows.Forms.TextBox();
            this.txtApuesta2 = new System.Windows.Forms.TextBox();
            this.txtApuesta1c = new System.Windows.Forms.TextBox();
            this.txtApuesta2c = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btn2Jugadores = new System.Windows.Forms.Button();
            this.btn1jugador = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apuesta jugador 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apuesta jugador :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apuesta computador:";
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
            // Form1
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblApuestaj1);
            this.Controls.Add(this.txtTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label lblApuestaj1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApuesta1;
        private System.Windows.Forms.TextBox txtApuesta2;
        private System.Windows.Forms.TextBox txtApuesta1c;
        private System.Windows.Forms.TextBox txtApuesta2c;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btn2Jugadores;
        private System.Windows.Forms.Button btn1jugador;
    }
}

