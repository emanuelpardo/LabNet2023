
namespace labNetPractica2
{
    partial class FrmPractica2
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
            this.btnPrimerPunto = new System.Windows.Forms.Button();
            this.BtnPuntoDos = new System.Windows.Forms.Button();
            this.btnPuntoTres = new System.Windows.Forms.Button();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.btnPuntoCuatro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrimerPunto
            // 
            this.btnPrimerPunto.Location = new System.Drawing.Point(12, 125);
            this.btnPrimerPunto.Name = "btnPrimerPunto";
            this.btnPrimerPunto.Size = new System.Drawing.Size(92, 51);
            this.btnPrimerPunto.TabIndex = 0;
            this.btnPrimerPunto.Text = "1er punto";
            this.btnPrimerPunto.UseVisualStyleBackColor = true;
            this.btnPrimerPunto.Click += new System.EventHandler(this.btnPrimerPunto_Click);
            // 
            // BtnPuntoDos
            // 
            this.BtnPuntoDos.Location = new System.Drawing.Point(12, 182);
            this.BtnPuntoDos.Name = "BtnPuntoDos";
            this.BtnPuntoDos.Size = new System.Drawing.Size(92, 51);
            this.BtnPuntoDos.TabIndex = 1;
            this.BtnPuntoDos.Text = "2do Punto";
            this.BtnPuntoDos.UseVisualStyleBackColor = true;
            this.BtnPuntoDos.Click += new System.EventHandler(this.BtnPuntoDos_Click);
            // 
            // btnPuntoTres
            // 
            this.btnPuntoTres.Location = new System.Drawing.Point(12, 247);
            this.btnPuntoTres.Name = "btnPuntoTres";
            this.btnPuntoTres.Size = new System.Drawing.Size(92, 51);
            this.btnPuntoTres.TabIndex = 2;
            this.btnPuntoTres.Text = "3er Punto";
            this.btnPuntoTres.UseVisualStyleBackColor = true;
            this.btnPuntoTres.Click += new System.EventHandler(this.btnPuntoTres_Click);
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(13, 38);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(167, 20);
            this.txtNumeroUno.TabIndex = 3;
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(13, 78);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(167, 20);
            this.txtNumeroDos.TabIndex = 4;
            // 
            // btnPuntoCuatro
            // 
            this.btnPuntoCuatro.Location = new System.Drawing.Point(15, 314);
            this.btnPuntoCuatro.Name = "btnPuntoCuatro";
            this.btnPuntoCuatro.Size = new System.Drawing.Size(92, 51);
            this.btnPuntoCuatro.TabIndex = 5;
            this.btnPuntoCuatro.Text = "4to Punto";
            this.btnPuntoCuatro.UseVisualStyleBackColor = true;
            this.btnPuntoCuatro.Click += new System.EventHandler(this.btnPuntoCuatro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dividendo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Divisor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "toma solo el Dividendo\r\nlo divide por 0\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "toma ambos: \r\n-Dividendo\r\n-Divisor\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 52);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hace división. \r\nExcepcion si \r\nalgun textbox \r\nestá vacío ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 52);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hace división. \r\nExcepcion Personalizada\r\nsi algun textbox \r\nestá vacío ";
            // 
            // FrmPractica2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 393);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPuntoCuatro);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.btnPuntoTres);
            this.Controls.Add(this.BtnPuntoDos);
            this.Controls.Add(this.btnPrimerPunto);
            this.Name = "FrmPractica2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practica 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimerPunto;
        private System.Windows.Forms.Button BtnPuntoDos;
        private System.Windows.Forms.Button btnPuntoTres;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.Button btnPuntoCuatro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

