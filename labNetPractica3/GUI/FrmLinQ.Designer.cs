
namespace GUI
{
    partial class FrmLinQ
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
            this.PanelShippers = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.dgvLinq = new System.Windows.Forms.DataGridView();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.flowPanelBotones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnDiez = new System.Windows.Forms.Button();
            this.btnOnce = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTrece = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.PanelShippers.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinq)).BeginInit();
            this.flowPanelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelShippers
            // 
            this.PanelShippers.ColumnCount = 2;
            this.PanelShippers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.PanelShippers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89F));
            this.PanelShippers.Controls.Add(this.panel1, 0, 0);
            this.PanelShippers.Controls.Add(this.dgvLinq, 1, 0);
            this.PanelShippers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelShippers.Location = new System.Drawing.Point(0, 0);
            this.PanelShippers.Name = "PanelShippers";
            this.PanelShippers.RowCount = 1;
            this.PanelShippers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PanelShippers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PanelShippers.Size = new System.Drawing.Size(800, 450);
            this.PanelShippers.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblinfo);
            this.panel1.Controls.Add(this.flowPanelBotones);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 444);
            this.panel1.TabIndex = 0;
            // 
            // btnDos
            // 
            this.btnDos.Location = new System.Drawing.Point(39, 3);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(30, 30);
            this.btnDos.TabIndex = 2;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(5, 383);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(69, 52);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnUno
            // 
            this.btnUno.Location = new System.Drawing.Point(3, 3);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(30, 30);
            this.btnUno.TabIndex = 0;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // dgvLinq
            // 
            this.dgvLinq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinq.Location = new System.Drawing.Point(91, 3);
            this.dgvLinq.Name = "dgvLinq";
            this.dgvLinq.Size = new System.Drawing.Size(706, 444);
            this.dgvLinq.TabIndex = 1;
            // 
            // btnTres
            // 
            this.btnTres.Location = new System.Drawing.Point(3, 39);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(30, 30);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Location = new System.Drawing.Point(39, 39);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(30, 30);
            this.btnCuatro.TabIndex = 4;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Location = new System.Drawing.Point(3, 75);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(30, 30);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Location = new System.Drawing.Point(39, 75);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(30, 30);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // flowPanelBotones
            // 
            this.flowPanelBotones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPanelBotones.Controls.Add(this.btnUno);
            this.flowPanelBotones.Controls.Add(this.btnDos);
            this.flowPanelBotones.Controls.Add(this.btnTres);
            this.flowPanelBotones.Controls.Add(this.btnCuatro);
            this.flowPanelBotones.Controls.Add(this.btnCinco);
            this.flowPanelBotones.Controls.Add(this.btnSeis);
            this.flowPanelBotones.Controls.Add(this.btnSiete);
            this.flowPanelBotones.Controls.Add(this.btnOcho);
            this.flowPanelBotones.Controls.Add(this.btnNueve);
            this.flowPanelBotones.Controls.Add(this.btnDiez);
            this.flowPanelBotones.Controls.Add(this.btnOnce);
            this.flowPanelBotones.Controls.Add(this.button1);
            this.flowPanelBotones.Controls.Add(this.btnTrece);
            this.flowPanelBotones.Location = new System.Drawing.Point(3, 26);
            this.flowPanelBotones.Name = "flowPanelBotones";
            this.flowPanelBotones.Size = new System.Drawing.Size(79, 351);
            this.flowPanelBotones.TabIndex = 8;
            // 
            // btnSiete
            // 
            this.btnSiete.Location = new System.Drawing.Point(3, 111);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(30, 30);
            this.btnSiete.TabIndex = 8;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Location = new System.Drawing.Point(39, 111);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(30, 30);
            this.btnOcho.TabIndex = 9;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Location = new System.Drawing.Point(3, 147);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(30, 30);
            this.btnNueve.TabIndex = 10;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnDiez
            // 
            this.btnDiez.Location = new System.Drawing.Point(39, 147);
            this.btnDiez.Name = "btnDiez";
            this.btnDiez.Size = new System.Drawing.Size(30, 30);
            this.btnDiez.TabIndex = 11;
            this.btnDiez.Text = "10";
            this.btnDiez.UseVisualStyleBackColor = true;
            this.btnDiez.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnOnce
            // 
            this.btnOnce.Location = new System.Drawing.Point(3, 183);
            this.btnOnce.Name = "btnOnce";
            this.btnOnce.Size = new System.Drawing.Size(30, 30);
            this.btnOnce.TabIndex = 12;
            this.btnOnce.Text = "11";
            this.btnOnce.UseVisualStyleBackColor = true;
            this.btnOnce.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "12";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // btnTrece
            // 
            this.btnTrece.Location = new System.Drawing.Point(3, 219);
            this.btnTrece.Name = "btnTrece";
            this.btnTrece.Size = new System.Drawing.Size(30, 30);
            this.btnTrece.TabIndex = 14;
            this.btnTrece.Text = "13";
            this.btnTrece.UseVisualStyleBackColor = true;
            this.btnTrece.Click += new System.EventHandler(this.btnPuntos_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(10, 9);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(58, 13);
            this.lblinfo.TabIndex = 9;
            this.lblinfo.Text = "N° Puntos:";
            // 
            // FrmLinQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelShippers);
            this.Name = "FrmLinQ";
            this.Text = "FrmLinQ";
            this.PanelShippers.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinq)).EndInit();
            this.flowPanelBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel PanelShippers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.DataGridView dgvLinq;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.FlowLayoutPanel flowPanelBotones;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnDiez;
        private System.Windows.Forms.Button btnOnce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTrece;
        private System.Windows.Forms.Label lblinfo;
    }
}