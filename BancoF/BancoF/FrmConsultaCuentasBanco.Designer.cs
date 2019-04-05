namespace BancoF
{
    partial class FrmConsultaCuentasBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCuentasBanco));
            this.lbCuentasBanco = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMontoMinimo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreSelected = new System.Windows.Forms.Label();
            this.lblMontoMInimoSelected = new System.Windows.Forms.Label();
            this.lblDescripcionSelected = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.msCuentasBanco = new System.Windows.Forms.MenuStrip();
            this.tsTecBank = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrarCuentasBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDiv = new System.Windows.Forms.Panel();
            this.msCuentasBanco.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCuentasBanco
            // 
            this.lbCuentasBanco.AutoSize = true;
            this.lbCuentasBanco.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuentasBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.lbCuentasBanco.Location = new System.Drawing.Point(26, 68);
            this.lbCuentasBanco.Name = "lbCuentasBanco";
            this.lbCuentasBanco.Size = new System.Drawing.Size(300, 54);
            this.lbCuentasBanco.TabIndex = 7;
            this.lbCuentasBanco.Text = "Cuentas Banco";
            // 
            // cmbNombre
            // 
            this.cmbNombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(719, 97);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(227, 21);
            this.cmbNombre.TabIndex = 8;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblNombre.Location = new System.Drawing.Point(69, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(86, 25);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMontoMinimo
            // 
            this.lblMontoMinimo.AutoSize = true;
            this.lblMontoMinimo.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblMontoMinimo.Location = new System.Drawing.Point(69, 172);
            this.lblMontoMinimo.Name = "lblMontoMinimo";
            this.lblMontoMinimo.Size = new System.Drawing.Size(147, 25);
            this.lblMontoMinimo.TabIndex = 15;
            this.lblMontoMinimo.Text = "Monto Minimo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(69, 268);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 25);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombreSelected
            // 
            this.lblNombreSelected.AutoSize = true;
            this.lblNombreSelected.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblNombreSelected.Location = new System.Drawing.Point(262, 75);
            this.lblNombreSelected.Name = "lblNombreSelected";
            this.lblNombreSelected.Size = new System.Drawing.Size(36, 25);
            this.lblNombreSelected.TabIndex = 17;
            this.lblNombreSelected.Text = "---";
            // 
            // lblMontoMInimoSelected
            // 
            this.lblMontoMInimoSelected.AutoSize = true;
            this.lblMontoMInimoSelected.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMInimoSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblMontoMInimoSelected.Location = new System.Drawing.Point(262, 162);
            this.lblMontoMInimoSelected.Name = "lblMontoMInimoSelected";
            this.lblMontoMInimoSelected.Size = new System.Drawing.Size(36, 25);
            this.lblMontoMInimoSelected.TabIndex = 18;
            this.lblMontoMInimoSelected.Text = "---";
            // 
            // lblDescripcionSelected
            // 
            this.lblDescripcionSelected.AutoSize = true;
            this.lblDescripcionSelected.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblDescripcionSelected.Location = new System.Drawing.Point(262, 268);
            this.lblDescripcionSelected.Name = "lblDescripcionSelected";
            this.lblDescripcionSelected.Size = new System.Drawing.Size(36, 25);
            this.lblDescripcionSelected.TabIndex = 19;
            this.lblDescripcionSelected.Text = "---";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(975, -1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // msCuentasBanco
            // 
            this.msCuentasBanco.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.msCuentasBanco.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTecBank});
            this.msCuentasBanco.Location = new System.Drawing.Point(0, 0);
            this.msCuentasBanco.Name = "msCuentasBanco";
            this.msCuentasBanco.Size = new System.Drawing.Size(1000, 27);
            this.msCuentasBanco.TabIndex = 22;
            this.msCuentasBanco.Text = "menuStrip1";
            // 
            // tsTecBank
            // 
            this.tsTecBank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCerrarCuentasBanco,
            this.toolStripSeparator1,
            this.tsSalir});
            this.tsTecBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsTecBank.Name = "tsTecBank";
            this.tsTecBank.Size = new System.Drawing.Size(77, 23);
            this.tsTecBank.Text = "TecBank";
            // 
            // tsCerrarCuentasBanco
            // 
            this.tsCerrarCuentasBanco.Font = new System.Drawing.Font("Ebrima", 10F);
            this.tsCerrarCuentasBanco.Name = "tsCerrarCuentasBanco";
            this.tsCerrarCuentasBanco.Size = new System.Drawing.Size(211, 24);
            this.tsCerrarCuentasBanco.Text = "Cerrar Cuentas Banco";
            this.tsCerrarCuentasBanco.Click += new System.EventHandler(this.tsCerrarCuentasBanco_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // tsSalir
            // 
            this.tsSalir.Font = new System.Drawing.Font("Ebrima", 10F);
            this.tsSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.tsSalir.Size = new System.Drawing.Size(211, 24);
            this.tsSalir.Text = "Salir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblDescripcionSelected);
            this.panel1.Controls.Add(this.lblMontoMinimo);
            this.panel1.Controls.Add(this.lblMontoMInimoSelected);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblNombreSelected);
            this.panel1.Location = new System.Drawing.Point(55, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 428);
            this.panel1.TabIndex = 25;
            // 
            // panelDiv
            // 
            this.panelDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.panelDiv.Location = new System.Drawing.Point(0, 453);
            this.panelDiv.Name = "panelDiv";
            this.panelDiv.Size = new System.Drawing.Size(1024, 164);
            this.panelDiv.TabIndex = 24;
            // 
            // FrmConsultaCuentasBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.lbCuentasBanco);
            this.Controls.Add(this.msCuentasBanco);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDiv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msCuentasBanco;
            this.Name = "FrmConsultaCuentasBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaCuentasBanco";
            this.Load += new System.EventHandler(this.FrmConsultaCuentasBanco_Load);
            this.msCuentasBanco.ResumeLayout(false);
            this.msCuentasBanco.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCuentasBanco;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMontoMinimo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombreSelected;
        private System.Windows.Forms.Label lblMontoMInimoSelected;
        private System.Windows.Forms.Label lblDescripcionSelected;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip msCuentasBanco;
        private System.Windows.Forms.ToolStripMenuItem tsTecBank;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDiv;
        private System.Windows.Forms.ToolStripMenuItem tsCerrarCuentasBanco;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}