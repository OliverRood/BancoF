namespace BancoF
{
    partial class frmConsultaCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCuentas));
            this.lblCuentas = new System.Windows.Forms.Label();
            this.cmbClaveCliente = new System.Windows.Forms.ComboBox();
            this.lblClaveCliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.txtMontoAper = new System.Windows.Forms.TextBox();
            this.lblMontoAper = new System.Windows.Forms.Label();
            this.lblTipodeCuenta = new System.Windows.Forms.Label();
            this.txtTipoCuenta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCuentas.Location = new System.Drawing.Point(75, 55);
            this.lblCuentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(123, 32);
            this.lblCuentas.TabIndex = 2;
            this.lblCuentas.Text = "Cuentas";
            // 
            // cmbClaveCliente
            // 
            this.cmbClaveCliente.BackColor = System.Drawing.SystemColors.Window;
            this.cmbClaveCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClaveCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClaveCliente.FormattingEnabled = true;
            this.cmbClaveCliente.Location = new System.Drawing.Point(63, 146);
            this.cmbClaveCliente.Name = "cmbClaveCliente";
            this.cmbClaveCliente.Size = new System.Drawing.Size(196, 24);
            this.cmbClaveCliente.TabIndex = 10;
            // 
            // lblClaveCliente
            // 
            this.lblClaveCliente.AutoSize = true;
            this.lblClaveCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCliente.Location = new System.Drawing.Point(60, 115);
            this.lblClaveCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClaveCliente.Name = "lblClaveCliente";
            this.lblClaveCliente.Size = new System.Drawing.Size(111, 17);
            this.lblClaveCliente.TabIndex = 11;
            this.lblClaveCliente.Text = "Clave del cliente";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(396, 154);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 20;
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCuenta.Location = new System.Drawing.Point(393, 124);
            this.lblNumeroCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(125, 17);
            this.lblNumeroCuenta.TabIndex = 19;
            this.lblNumeroCuenta.Text = "Número de cuenta";
            // 
            // txtMontoAper
            // 
            this.txtMontoAper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMontoAper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoAper.Location = new System.Drawing.Point(396, 289);
            this.txtMontoAper.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoAper.Name = "txtMontoAper";
            this.txtMontoAper.ReadOnly = true;
            this.txtMontoAper.Size = new System.Drawing.Size(233, 20);
            this.txtMontoAper.TabIndex = 18;
            // 
            // lblMontoAper
            // 
            this.lblMontoAper.AutoSize = true;
            this.lblMontoAper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAper.Location = new System.Drawing.Point(393, 259);
            this.lblMontoAper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAper.Name = "lblMontoAper";
            this.lblMontoAper.Size = new System.Drawing.Size(125, 17);
            this.lblMontoAper.TabIndex = 17;
            this.lblMontoAper.Text = "Monto de apertura";
            // 
            // lblTipodeCuenta
            // 
            this.lblTipodeCuenta.AutoSize = true;
            this.lblTipodeCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeCuenta.Location = new System.Drawing.Point(393, 189);
            this.lblTipodeCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipodeCuenta.Name = "lblTipodeCuenta";
            this.lblTipodeCuenta.Size = new System.Drawing.Size(107, 17);
            this.lblTipodeCuenta.TabIndex = 15;
            this.lblTipodeCuenta.Text = "Tipo de cuenta ";
            // 
            // txtTipoCuenta
            // 
            this.txtTipoCuenta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTipoCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipoCuenta.Location = new System.Drawing.Point(396, 224);
            this.txtTipoCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.ReadOnly = true;
            this.txtTipoCuenta.Size = new System.Drawing.Size(233, 20);
            this.txtTipoCuenta.TabIndex = 21;
            // 
            // frmConsultaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 409);
            this.Controls.Add(this.txtTipoCuenta);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumeroCuenta);
            this.Controls.Add(this.txtMontoAper);
            this.Controls.Add(this.lblMontoAper);
            this.Controls.Add(this.lblTipodeCuenta);
            this.Controls.Add(this.lblClaveCliente);
            this.Controls.Add(this.cmbClaveCliente);
            this.Controls.Add(this.lblCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaCuentas";
            this.Text = "frmConsultaCuenta";
            this.Load += new System.EventHandler(this.frmConsultaCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.ComboBox cmbClaveCliente;
        private System.Windows.Forms.Label lblClaveCliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.TextBox txtMontoAper;
        private System.Windows.Forms.Label lblMontoAper;
        private System.Windows.Forms.Label lblTipodeCuenta;
        private System.Windows.Forms.TextBox txtTipoCuenta;
    }
}