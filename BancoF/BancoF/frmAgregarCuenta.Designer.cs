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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCuenta));
            this.lblCuentas = new System.Windows.Forms.Label();
            this.lblTipodeCuenta = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblMontoAper = new System.Windows.Forms.Label();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.txtNumCuenta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msktxtMonto = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCuentas.Location = new System.Drawing.Point(178, 135);
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
            this.cmbTipoCuenta.Location = new System.Drawing.Point(543, 252);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(262, 24);
            this.cmbTipoCuenta.TabIndex = 9;
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
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.Size = new System.Drawing.Size(288, 25);
            this.txtNumCuenta.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.CausesValidation = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.button1.Location = new System.Drawing.Point(610, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // msktxtMonto
            // 
            this.msktxtMonto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtMonto.Location = new System.Drawing.Point(543, 334);
            this.msktxtMonto.Mask = "$";
            this.msktxtMonto.Name = "msktxtMonto";
            this.msktxtMonto.Size = new System.Drawing.Size(262, 24);
            this.msktxtMonto.TabIndex = 19;
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
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // btnSalir
            // 
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
            // 
            // frmAgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.msktxtMonto);
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
            this.Text = "Añadir nueva cuenta";
            this.Load += new System.EventHandler(this.frmAgregarCuenta_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox msktxtMonto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
    }
}