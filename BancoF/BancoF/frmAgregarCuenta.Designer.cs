namespace BancoF
{
    partial class frmAgregarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCuenta));
            this.lblCuentas = new System.Windows.Forms.Label();
            this.lblTipodeCuenta = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblMontoAper = new System.Windows.Forms.Label();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGuardarCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtMontoApertura = new System.Windows.Forms.TextBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblDatosTipo = new System.Windows.Forms.Label();
            this.lblDescripción = new System.Windows.Forms.Label();
            this.rchDesc = new System.Windows.Forms.RichTextBox();
            this.lblMontoMin = new System.Windows.Forms.Label();
            this.txtMontoMin = new System.Windows.Forms.TextBox();
            this.panelDiv = new System.Windows.Forms.Panel();
            this.tlpCuentas = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCuentas.Location = new System.Drawing.Point(169, 135);
            this.lblCuentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(123, 32);
            this.lblCuentas.TabIndex = 1;
            this.lblCuentas.Text = "Cuentas";
            // 
            // lblTipodeCuenta
            // 
            this.lblTipodeCuenta.AutoSize = true;
            this.lblTipodeCuenta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeCuenta.Location = new System.Drawing.Point(540, 222);
            this.lblTipodeCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipodeCuenta.Name = "lblTipodeCuenta";
            this.lblTipodeCuenta.Size = new System.Drawing.Size(107, 17);
            this.lblTipodeCuenta.TabIndex = 8;
            this.lblTipodeCuenta.Text = "Tipo de cuenta ";
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Items.AddRange(new object[] {
            "SELECCIONE EL TIPO DE CUENTA"});
            this.cmbTipoCuenta.Location = new System.Drawing.Point(543, 252);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(262, 24);
            this.cmbTipoCuenta.TabIndex = 2;
            this.cmbTipoCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCuenta_SelectedIndexChanged);
            this.cmbTipoCuenta.Validated += new System.EventHandler(this.ValidaTipoCuenta);
            // 
            // lblMontoAper
            // 
            this.lblMontoAper.AutoSize = true;
            this.lblMontoAper.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAper.Location = new System.Drawing.Point(540, 303);
            this.lblMontoAper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAper.Name = "lblMontoAper";
            this.lblMontoAper.Size = new System.Drawing.Size(125, 17);
            this.lblMontoAper.TabIndex = 11;
            this.lblMontoAper.Text = "Monto de apertura";
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCuenta.Location = new System.Drawing.Point(540, 150);
            this.lblNumeroCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(128, 17);
            this.lblNumeroCuenta.TabIndex = 13;
            this.lblNumeroCuenta.Text = "Número de cuenta";
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumCuenta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCuenta.Location = new System.Drawing.Point(543, 180);
            this.txtNumCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumCuenta.MaxLength = 7;
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(288, 25);
            this.txtNumCuenta.TabIndex = 1;
            this.txtNumCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumCuenta_KeyPress);
            this.txtNumCuenta.Validated += new System.EventHandler(this.ValidaNumCuenta);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.button1.CausesValidation = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.button1.Location = new System.Drawing.Point(610, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGuardarCuenta,
            this.tsSalir});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // tsGuardarCuenta
            // 
            this.tsGuardarCuenta.Name = "tsGuardarCuenta";
            this.tsGuardarCuenta.Size = new System.Drawing.Size(116, 22);
            this.tsGuardarCuenta.Text = "Guardar";
            this.tsGuardarCuenta.Click += new System.EventHandler(this.tsGuardarCuenta_Click);
            // 
            // tsSalir
            // 
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(116, 22);
            this.tsSalir.Text = "Salir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.CausesValidation = false;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(975, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 29);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtMontoApertura
            // 
            this.txtMontoApertura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMontoApertura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoApertura.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoApertura.Location = new System.Drawing.Point(543, 335);
            this.txtMontoApertura.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoApertura.Name = "txtMontoApertura";
            this.txtMontoApertura.Size = new System.Drawing.Size(262, 25);
            this.txtMontoApertura.TabIndex = 3;
            this.txtMontoApertura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoApertura_KeyPress);
            this.txtMontoApertura.Validated += new System.EventHandler(this.ValidaMontoApertura);
            // 
            // errorP
            // 
            this.errorP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorP.ContainerControl = this;
            this.errorP.Icon = ((System.Drawing.Icon)(resources.GetObject("errorP.Icon")));
            // 
            // lblDatosTipo
            // 
            this.lblDatosTipo.AutoSize = true;
            this.lblDatosTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosTipo.Location = new System.Drawing.Point(66, 222);
            this.lblDatosTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatosTipo.Name = "lblDatosTipo";
            this.lblDatosTipo.Size = new System.Drawing.Size(245, 19);
            this.lblDatosTipo.TabIndex = 23;
            this.lblDatosTipo.Text = "Información del tipo de cuenta:";
            // 
            // lblDescripción
            // 
            this.lblDescripción.AutoSize = true;
            this.lblDescripción.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripción.Location = new System.Drawing.Point(71, 273);
            this.lblDescripción.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripción.Name = "lblDescripción";
            this.lblDescripción.Size = new System.Drawing.Size(97, 18);
            this.lblDescripción.TabIndex = 24;
            this.lblDescripción.Text = "Descripción:";
            // 
            // rchDesc
            // 
            this.rchDesc.BackColor = System.Drawing.SystemColors.Control;
            this.rchDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchDesc.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchDesc.Location = new System.Drawing.Point(175, 273);
            this.rchDesc.Name = "rchDesc";
            this.rchDesc.Size = new System.Drawing.Size(277, 76);
            this.rchDesc.TabIndex = 25;
            this.rchDesc.Text = "";
            // 
            // lblMontoMin
            // 
            this.lblMontoMin.AutoSize = true;
            this.lblMontoMin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMin.Location = new System.Drawing.Point(71, 373);
            this.lblMontoMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoMin.Name = "lblMontoMin";
            this.lblMontoMin.Size = new System.Drawing.Size(112, 18);
            this.lblMontoMin.TabIndex = 26;
            this.lblMontoMin.Text = "Monto Minimo:";
            // 
            // txtMontoMin
            // 
            this.txtMontoMin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMontoMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoMin.Enabled = false;
            this.txtMontoMin.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoMin.Location = new System.Drawing.Point(245, 367);
            this.txtMontoMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoMin.Name = "txtMontoMin";
            this.txtMontoMin.ReadOnly = true;
            this.txtMontoMin.Size = new System.Drawing.Size(113, 24);
            this.txtMontoMin.TabIndex = 27;
            this.txtMontoMin.Visible = false;
            // 
            // panelDiv
            // 
            this.panelDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.panelDiv.Location = new System.Drawing.Point(0, 546);
            this.panelDiv.Name = "panelDiv";
            this.panelDiv.Size = new System.Drawing.Size(1000, 55);
            this.panelDiv.TabIndex = 29;
            // 
            // tlpCuentas
            // 
            this.tlpCuentas.ToolTipTitle = "Información de la cuenta";
            // 
            // frmAgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelDiv);
            this.Controls.Add(this.txtMontoMin);
            this.Controls.Add(this.lblMontoMin);
            this.Controls.Add(this.rchDesc);
            this.Controls.Add(this.lblDescripción);
            this.Controls.Add(this.lblDatosTipo);
            this.Controls.Add(this.txtMontoApertura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumCuenta);
            this.Controls.Add(this.lblNumeroCuenta);
            this.Controls.Add(this.lblMontoAper);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.lblTipodeCuenta);
            this.Controls.Add(this.lblCuentas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAgregarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir nueva cuenta";
            this.Load += new System.EventHandler(this.frmAgregarCuenta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.Label lblTipodeCuenta;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label lblMontoAper;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.TextBox txtNumCuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsGuardarCuenta;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtMontoApertura;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Label lblDatosTipo;
        private System.Windows.Forms.Label lblDescripción;
        private System.Windows.Forms.RichTextBox rchDesc;
        private System.Windows.Forms.Label lblMontoMin;
        private System.Windows.Forms.TextBox txtMontoMin;
        private System.Windows.Forms.Panel panelDiv;
        private System.Windows.Forms.ToolTip tlpCuentas;
    }
}