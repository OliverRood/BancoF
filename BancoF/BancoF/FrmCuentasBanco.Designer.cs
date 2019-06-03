namespace BancoF
{
    partial class FrmCuentasBanco
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuentasBanco));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMontoMinimo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.epCuentasBanco = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.lbCuentasBanco = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMontoMinimo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panelDiv = new System.Windows.Forms.Panel();
            this.msCuentasBanco = new System.Windows.Forms.MenuStrip();
            this.tsTecBank = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarTipoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCuentasBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipCB = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epCuentasBanco)).BeginInit();
            this.msCuentasBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.Location = new System.Drawing.Point(260, 209);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(482, 19);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // txtMontoMinimo
            // 
            this.txtMontoMinimo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoMinimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoMinimo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMontoMinimo.Location = new System.Drawing.Point(260, 304);
            this.txtMontoMinimo.Name = "txtMontoMinimo";
            this.txtMontoMinimo.Size = new System.Drawing.Size(482, 19);
            this.txtMontoMinimo.TabIndex = 16;
            this.txtMontoMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoMinimo_KeyPress);
            this.txtMontoMinimo.Validated += new System.EventHandler(this.txtMontoMinimo_Validated);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescripcion.Location = new System.Drawing.Point(260, 396);
            this.txtDescripcion.MaxLength = 80;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(482, 19);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            this.txtDescripcion.Validated += new System.EventHandler(this.txtDescripcion_Validated);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnLimpiar.Location = new System.Drawing.Point(742, 496);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 39);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // epCuentasBanco
            // 
            this.epCuentasBanco.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(959, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbCuentasBanco
            // 
            this.lbCuentasBanco.AutoSize = true;
            this.lbCuentasBanco.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuentasBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.lbCuentasBanco.Location = new System.Drawing.Point(35, 68);
            this.lbCuentasBanco.Name = "lbCuentasBanco";
            this.lbCuentasBanco.Size = new System.Drawing.Size(300, 54);
            this.lbCuentasBanco.TabIndex = 26;
            this.lbCuentasBanco.Text = "Cuentas Banco";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblNombre.Location = new System.Drawing.Point(225, 169);
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
            this.lblMontoMinimo.Location = new System.Drawing.Point(225, 266);
            this.lblMontoMinimo.Name = "lblMontoMinimo";
            this.lblMontoMinimo.Size = new System.Drawing.Size(147, 25);
            this.lblMontoMinimo.TabIndex = 15;
            this.lblMontoMinimo.Text = "Monto Minimo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(225, 362);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(116, 25);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // panelDiv
            // 
            this.panelDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.panelDiv.Location = new System.Drawing.Point(0, 516);
            this.panelDiv.Name = "panelDiv";
            this.panelDiv.Size = new System.Drawing.Size(1024, 133);
            this.panelDiv.TabIndex = 27;
            // 
            // msCuentasBanco
            // 
            this.msCuentasBanco.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.msCuentasBanco.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTecBank});
            this.msCuentasBanco.Location = new System.Drawing.Point(0, 0);
            this.msCuentasBanco.Name = "msCuentasBanco";
            this.msCuentasBanco.Size = new System.Drawing.Size(984, 27);
            this.msCuentasBanco.TabIndex = 33;
            this.msCuentasBanco.Text = "menuStrip1";
            // 
            // tsTecBank
            // 
            this.tsTecBank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarTipoCuentaToolStripMenuItem,
            this.cerrarCuentasBancoToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.tsTecBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsTecBank.Name = "tsTecBank";
            this.tsTecBank.Size = new System.Drawing.Size(77, 23);
            this.tsTecBank.Text = "TecBank";
            // 
            // guardarTipoCuentaToolStripMenuItem
            // 
            this.guardarTipoCuentaToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.guardarTipoCuentaToolStripMenuItem.Name = "guardarTipoCuentaToolStripMenuItem";
            this.guardarTipoCuentaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.guardarTipoCuentaToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.guardarTipoCuentaToolStripMenuItem.Text = "Guardar tipo cuenta";
            this.guardarTipoCuentaToolStripMenuItem.Click += new System.EventHandler(this.guardarTipoCuentaToolStripMenuItem_Click);
            // 
            // cerrarCuentasBancoToolStripMenuItem
            // 
            this.cerrarCuentasBancoToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.cerrarCuentasBancoToolStripMenuItem.Name = "cerrarCuentasBancoToolStripMenuItem";
            this.cerrarCuentasBancoToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.cerrarCuentasBancoToolStripMenuItem.Text = "Cerrar Cuentas Banco";
            this.cerrarCuentasBancoToolStripMenuItem.Click += new System.EventHandler(this.cerrarCuentasBancoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(244, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // FrmCuentasBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblMontoMinimo);
            this.Controls.Add(this.txtMontoMinimo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbCuentasBanco);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.panelDiv);
            this.Controls.Add(this.msCuentasBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCuentasBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuentasBanco";
            this.Load += new System.EventHandler(this.FrmCuentasBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epCuentasBanco)).EndInit();
            this.msCuentasBanco.ResumeLayout(false);
            this.msCuentasBanco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMontoMinimo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider epCuentasBanco;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMontoMinimo;
        private System.Windows.Forms.Label lbCuentasBanco;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Panel panelDiv;
        private System.Windows.Forms.MenuStrip msCuentasBanco;
        private System.Windows.Forms.ToolStripMenuItem tsTecBank;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarCuentasBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolTip toolTipCB;
        private System.Windows.Forms.ToolStripMenuItem guardarTipoCuentaToolStripMenuItem;
    }
}