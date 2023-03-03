
namespace labNetPractica1
{
    partial class FrmTransportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(412, 373);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 38);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(490, 206);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(197, 236);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 38);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Transporte";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(197, 280);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(90, 38);
            this.btnAvanzar.TabIndex = 3;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(197, 324);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(90, 38);
            this.btnDetener.TabIndex = 4;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            // 
            // FrmTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 418);
            this.ControlBox = false;
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmTransportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportes publicos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnDetener;
    }
}