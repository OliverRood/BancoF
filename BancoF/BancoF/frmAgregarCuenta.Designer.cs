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
            this.lblNúmeroCliente = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblTipodeCuenta = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblMontoAper = new System.Windows.Forms.Label();
            this.txtMontoAper = new System.Windows.Forms.TextBox();
            this.lblNumeroCuenta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGuardarCliente = new System.Windows.Forms.Button();
            this.btnConsultaCuenta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCuentas
            // 
            this.lblCuentas.AutoSize = true;
            this.lblCuentas.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblCuentas.Location = new System.Drawing.Point(277, 54);
            this.lblCuentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuentas.Name = "lblCuentas";
            this.lblCuentas.Size = new System.Drawing.Size(123, 32);
            this.lblCuentas.TabIndex = 1;
            this.lblCuentas.Text = "Cuentas";
            // 
            // lblNúmeroCliente
            // 
            this.lblNúmeroCliente.AutoSize = true;
            this.lblNúmeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNúmeroCliente.Location = new System.Drawing.Point(459, 95);
            this.lblNúmeroCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNúmeroCliente.Name = "lblNúmeroCliente";
            this.lblNúmeroCliente.Size = new System.Drawing.Size(111, 17);
            this.lblNúmeroCliente.TabIndex = 4;
            this.lblNúmeroCliente.Text = "Clave del cliente";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNumeroCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroCliente.Location = new System.Drawing.Point(462, 128);
            this.txtNumeroCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(248, 20);
            this.txtNumeroCliente.TabIndex = 7;
            // 
            // lblTipodeCuenta
            // 
            this.lblTipodeCuenta.AutoSize = true;
            this.lblTipodeCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeCuenta.Location = new System.Drawing.Point(459, 226);
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
            this.cmbTipoCuenta.Location = new System.Drawing.Point(462, 256);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(205, 24);
            this.cmbTipoCuenta.TabIndex = 9;
            // 
            // lblMontoAper
            // 
            this.lblMontoAper.AutoSize = true;
            this.lblMontoAper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAper.Location = new System.Drawing.Point(459, 296);
            this.lblMontoAper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoAper.Name = "lblMontoAper";
            this.lblMontoAper.Size = new System.Drawing.Size(125, 17);
            this.lblMontoAper.TabIndex = 11;
            this.lblMontoAper.Text = "Monto de apertura";
            // 
            // txtMontoAper
            // 
            this.txtMontoAper.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMontoAper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMontoAper.Location = new System.Drawing.Point(462, 326);
            this.txtMontoAper.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoAper.Name = "txtMontoAper";
            this.txtMontoAper.Size = new System.Drawing.Size(233, 20);
            this.txtMontoAper.TabIndex = 12;
            // 
            // lblNumeroCuenta
            // 
            this.lblNumeroCuenta.AutoSize = true;
            this.lblNumeroCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroCuenta.Location = new System.Drawing.Point(459, 161);
            this.lblNumeroCuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroCuenta.Name = "lblNumeroCuenta";
            this.lblNumeroCuenta.Size = new System.Drawing.Size(125, 17);
            this.lblNumeroCuenta.TabIndex = 13;
            this.lblNumeroCuenta.Text = "Número de cuenta";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(462, 191);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 14;
            // 
            // btnGuardarCliente
            // 
            this.btnGuardarCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardarCliente.Location = new System.Drawing.Point(54, 124);
            this.btnGuardarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarCliente.Name = "btnGuardarCliente";
            this.btnGuardarCliente.Size = new System.Drawing.Size(197, 48);
            this.btnGuardarCliente.TabIndex = 15;
            this.btnGuardarCliente.Text = "Guardar";
            this.btnGuardarCliente.UseVisualStyleBackColor = false;
            // 
            // btnConsultaCuenta
            // 
            this.btnConsultaCuenta.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnConsultaCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultaCuenta.Location = new System.Drawing.Point(54, 199);
            this.btnConsultaCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaCuenta.Name = "btnConsultaCuenta";
            this.btnConsultaCuenta.Size = new System.Drawing.Size(197, 53);
            this.btnConsultaCuenta.TabIndex = 16;
            this.btnConsultaCuenta.Text = "Consultar";
            this.btnConsultaCuenta.UseVisualStyleBackColor = false;
            this.btnConsultaCuenta.Click += new System.EventHandler(this.btnConsultaCuenta_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(64, 285);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(177, 38);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // frmAgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 412);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultaCuenta);
            this.Controls.Add(this.btnGuardarCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNumeroCuenta);
            this.Controls.Add(this.txtMontoAper);
            this.Controls.Add(this.lblMontoAper);
            this.Controls.Add(this.cmbTipoCuenta);
            this.Controls.Add(this.lblTipodeCuenta);
            this.Controls.Add(this.txtNumeroCliente);
            this.Controls.Add(this.lblNúmeroCliente);
            this.Controls.Add(this.lblCuentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarCuenta";
            this.Text = "Añadir nueva cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuentas;
        private System.Windows.Forms.Label lblNúmeroCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Label lblTipodeCuenta;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label lblMontoAper;
        private System.Windows.Forms.TextBox txtMontoAper;
        private System.Windows.Forms.Label lblNumeroCuenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGuardarCliente;
        private System.Windows.Forms.Button btnConsultaCuenta;
        private System.Windows.Forms.Button btnLimpiar;
    }
}