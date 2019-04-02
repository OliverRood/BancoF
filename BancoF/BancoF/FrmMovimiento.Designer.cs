namespace BancoF
{
    partial class FrmMovimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimiento));
            this.lbMovimientos = new System.Windows.Forms.Label();
            this.rdDeposito = new System.Windows.Forms.RadioButton();
            this.rdRetiro = new System.Windows.Forms.RadioButton();
            this.grpTipoMovimiento = new System.Windows.Forms.GroupBox();
            this.lblClaveCuenta = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRealizarMovimiento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpTipoMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMovimientos
            // 
            this.lbMovimientos.AutoSize = true;
            this.lbMovimientos.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.lbMovimientos.Location = new System.Drawing.Point(46, 41);
            this.lbMovimientos.Name = "lbMovimientos";
            this.lbMovimientos.Size = new System.Drawing.Size(206, 40);
            this.lbMovimientos.TabIndex = 5;
            this.lbMovimientos.Text = "Movimiento";
            // 
            // rdDeposito
            // 
            this.rdDeposito.AutoSize = true;
            this.rdDeposito.Checked = true;
            this.rdDeposito.FlatAppearance.BorderSize = 0;
            this.rdDeposito.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.rdDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDeposito.Location = new System.Drawing.Point(36, 45);
            this.rdDeposito.Name = "rdDeposito";
            this.rdDeposito.Size = new System.Drawing.Size(81, 21);
            this.rdDeposito.TabIndex = 0;
            this.rdDeposito.TabStop = true;
            this.rdDeposito.Text = "Deposito";
            this.rdDeposito.UseVisualStyleBackColor = true;
            // 
            // rdRetiro
            // 
            this.rdRetiro.AutoSize = true;
            this.rdRetiro.FlatAppearance.BorderSize = 0;
            this.rdRetiro.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.rdRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdRetiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRetiro.Location = new System.Drawing.Point(36, 75);
            this.rdRetiro.Name = "rdRetiro";
            this.rdRetiro.Size = new System.Drawing.Size(63, 21);
            this.rdRetiro.TabIndex = 1;
            this.rdRetiro.TabStop = true;
            this.rdRetiro.Text = "Retiro";
            this.rdRetiro.UseVisualStyleBackColor = true;
            // 
            // grpTipoMovimiento
            // 
            this.grpTipoMovimiento.Controls.Add(this.rdRetiro);
            this.grpTipoMovimiento.Controls.Add(this.rdDeposito);
            this.grpTipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.grpTipoMovimiento.Location = new System.Drawing.Point(104, 144);
            this.grpTipoMovimiento.Name = "grpTipoMovimiento";
            this.grpTipoMovimiento.Size = new System.Drawing.Size(212, 126);
            this.grpTipoMovimiento.TabIndex = 6;
            this.grpTipoMovimiento.TabStop = false;
            this.grpTipoMovimiento.Text = "Tipo de movimiento";
            // 
            // lblClaveCuenta
            // 
            this.lblClaveCuenta.AutoSize = true;
            this.lblClaveCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.lblClaveCuenta.Location = new System.Drawing.Point(385, 144);
            this.lblClaveCuenta.Name = "lblClaveCuenta";
            this.lblClaveCuenta.Size = new System.Drawing.Size(157, 20);
            this.lblClaveCuenta.TabIndex = 7;
            this.lblClaveCuenta.Text = "Clave de la cuenta";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.txtClave.Location = new System.Drawing.Point(424, 185);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(412, 19);
            this.txtClave.TabIndex = 8;
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.txtMonto.Location = new System.Drawing.Point(424, 290);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(412, 19);
            this.txtMonto.TabIndex = 10;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.lblMonto.Location = new System.Drawing.Point(385, 250);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(59, 20);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "Monto";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.txtNombre.Location = new System.Drawing.Point(424, 388);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(412, 19);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            this.lblNombre.Location = new System.Drawing.Point(387, 347);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(317, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre de quien realiza el movimiento";
            // 
            // btnRealizarMovimiento
            // 
            this.btnRealizarMovimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.btnRealizarMovimiento.FlatAppearance.BorderSize = 0;
            this.btnRealizarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarMovimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRealizarMovimiento.Location = new System.Drawing.Point(104, 450);
            this.btnRealizarMovimiento.Name = "btnRealizarMovimiento";
            this.btnRealizarMovimiento.Size = new System.Drawing.Size(189, 59);
            this.btnRealizarMovimiento.TabIndex = 13;
            this.btnRealizarMovimiento.Text = "Realizar movimiento";
            this.btnRealizarMovimiento.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.btnLimpiar.Location = new System.Drawing.Point(737, 476);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 33);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(976, -2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRealizarMovimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClaveCuenta);
            this.Controls.Add(this.grpTipoMovimiento);
            this.Controls.Add(this.lbMovimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecBank";
            this.Load += new System.EventHandler(this.FrmMovimiento_Load);
            this.grpTipoMovimiento.ResumeLayout(false);
            this.grpTipoMovimiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMovimientos;
        private System.Windows.Forms.RadioButton rdDeposito;
        private System.Windows.Forms.RadioButton rdRetiro;
        private System.Windows.Forms.GroupBox grpTipoMovimiento;
        private System.Windows.Forms.Label lblClaveCuenta;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRealizarMovimiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}