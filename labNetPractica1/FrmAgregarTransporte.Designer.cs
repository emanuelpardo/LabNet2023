
namespace labNetPractica1
{
    partial class FrmAgregarTransporte
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
            this.rbOmnibus = new System.Windows.Forms.RadioButton();
            this.rbTaxi = new System.Windows.Forms.RadioButton();
            this.panelAgregarTransporte = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtPasajeros = new System.Windows.Forms.TextBox();
            this.lblNumeroTrasnporte = new System.Windows.Forms.Label();
            this.lblpasajero = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelAgregarTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbOmnibus
            // 
            this.rbOmnibus.AutoSize = true;
            this.rbOmnibus.Checked = true;
            this.rbOmnibus.Location = new System.Drawing.Point(30, 42);
            this.rbOmnibus.Name = "rbOmnibus";
            this.rbOmnibus.Size = new System.Drawing.Size(66, 17);
            this.rbOmnibus.TabIndex = 0;
            this.rbOmnibus.TabStop = true;
            this.rbOmnibus.Text = "Omnibus";
            this.rbOmnibus.UseVisualStyleBackColor = true;
            // 
            // rbTaxi
            // 
            this.rbTaxi.AutoSize = true;
            this.rbTaxi.Location = new System.Drawing.Point(149, 42);
            this.rbTaxi.Name = "rbTaxi";
            this.rbTaxi.Size = new System.Drawing.Size(45, 17);
            this.rbTaxi.TabIndex = 1;
            this.rbTaxi.Text = "Taxi";
            this.rbTaxi.UseVisualStyleBackColor = true;
            // 
            // panelAgregarTransporte
            // 
            this.panelAgregarTransporte.Controls.Add(this.btnCerrar);
            this.panelAgregarTransporte.Controls.Add(this.btnAgregar);
            this.panelAgregarTransporte.Controls.Add(this.lblpasajero);
            this.panelAgregarTransporte.Controls.Add(this.lblNumeroTrasnporte);
            this.panelAgregarTransporte.Controls.Add(this.txtPasajeros);
            this.panelAgregarTransporte.Controls.Add(this.txtNumero);
            this.panelAgregarTransporte.Controls.Add(this.lblTipo);
            this.panelAgregarTransporte.Controls.Add(this.rbOmnibus);
            this.panelAgregarTransporte.Controls.Add(this.rbTaxi);
            this.panelAgregarTransporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAgregarTransporte.Location = new System.Drawing.Point(0, 0);
            this.panelAgregarTransporte.Name = "panelAgregarTransporte";
            this.panelAgregarTransporte.Size = new System.Drawing.Size(262, 220);
            this.panelAgregarTransporte.TabIndex = 2;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(100, 9);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(28, 95);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(206, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtPasajeros
            // 
            this.txtPasajeros.Location = new System.Drawing.Point(28, 140);
            this.txtPasajeros.Name = "txtPasajeros";
            this.txtPasajeros.Size = new System.Drawing.Size(206, 20);
            this.txtPasajeros.TabIndex = 4;
            this.txtPasajeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // lblNumeroTrasnporte
            // 
            this.lblNumeroTrasnporte.AutoSize = true;
            this.lblNumeroTrasnporte.Location = new System.Drawing.Point(27, 79);
            this.lblNumeroTrasnporte.Name = "lblNumeroTrasnporte";
            this.lblNumeroTrasnporte.Size = new System.Drawing.Size(97, 13);
            this.lblNumeroTrasnporte.TabIndex = 5;
            this.lblNumeroTrasnporte.Text = "Numero transporte:";
            // 
            // lblpasajero
            // 
            this.lblpasajero.AutoSize = true;
            this.lblpasajero.Location = new System.Drawing.Point(30, 124);
            this.lblpasajero.Name = "lblpasajero";
            this.lblpasajero.Size = new System.Drawing.Size(100, 13);
            this.lblpasajero.TabIndex = 6;
            this.lblpasajero.Text = "Cantidad pasajeros:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(159, 185);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmAgregarTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 220);
            this.ControlBox = false;
            this.Controls.Add(this.panelAgregarTransporte);
            this.Name = "FrmAgregarTransporte";
            this.Text = "Agregar Transporte";
            this.panelAgregarTransporte.ResumeLayout(false);
            this.panelAgregarTransporte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbOmnibus;
        private System.Windows.Forms.RadioButton rbTaxi;
        private System.Windows.Forms.Panel panelAgregarTransporte;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtPasajeros;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblpasajero;
        private System.Windows.Forms.Label lblNumeroTrasnporte;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
    }
}