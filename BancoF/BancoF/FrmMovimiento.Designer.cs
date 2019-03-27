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
            this.btnConsultarMovimientos = new System.Windows.Forms.Button();
            this.btnRealizarMovimiento = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpTipoMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMovimientos
            // 
            this.lbMovimientos.AutoSize = true;
            this.lbMovimientos.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbMovimientos.Location = new System.Drawing.Point(19, 28);
            this.lbMovimientos.Name = "lbMovimientos";
            this.lbMovimientos.Size = new System.Drawing.Size(183, 32);
            this.lbMovimientos.TabIndex = 5;
            this.lbMovimientos.Text = "Movimientos";
            // 
            // rdDeposito
            // 
            this.rdDeposito.AutoSize = true;
            this.rdDeposito.Checked = true;
            this.rdDeposito.Location = new System.Drawing.Point(31, 31);
            this.rdDeposito.Name = "rdDeposito";
            this.rdDeposito.Size = new System.Drawing.Size(67, 17);
            this.rdDeposito.TabIndex = 0;
            this.rdDeposito.TabStop = true;
            this.rdDeposito.Text = "Deposito";
            this.rdDeposito.UseVisualStyleBackColor = true;
            // 
            // rdRetiro
            // 
            this.rdRetiro.AutoSize = true;
            this.rdRetiro.Location = new System.Drawing.Point(31, 61);
            this.rdRetiro.Name = "rdRetiro";
            this.rdRetiro.Size = new System.Drawing.Size(53, 17);
            this.rdRetiro.TabIndex = 1;
            this.rdRetiro.TabStop = true;
            this.rdRetiro.Text = "Retiro";
            this.rdRetiro.UseVisualStyleBackColor = true;
            // 
            // grpTipoMovimiento
            // 
            this.grpTipoMovimiento.Controls.Add(this.rdRetiro);
            this.grpTipoMovimiento.Controls.Add(this.rdDeposito);
            this.grpTipoMovimiento.Location = new System.Drawing.Point(25, 86);
            this.grpTipoMovimiento.Name = "grpTipoMovimiento";
            this.grpTipoMovimiento.Size = new System.Drawing.Size(177, 98);
            this.grpTipoMovimiento.TabIndex = 6;
            this.grpTipoMovimiento.TabStop = false;
            this.grpTipoMovimiento.Text = "Tipo de movimiento";
            // 
            // lblClaveCuenta
            // 
            this.lblClaveCuenta.AutoSize = true;
            this.lblClaveCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCuenta.Location = new System.Drawing.Point(261, 86);
            this.lblClaveCuenta.Name = "lblClaveCuenta";
            this.lblClaveCuenta.Size = new System.Drawing.Size(125, 17);
            this.lblClaveCuenta.TabIndex = 7;
            this.lblClaveCuenta.Text = "Clave de la cuenta";
            // 
            // txtClave
            // 
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(264, 117);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(318, 21);
            this.txtClave.TabIndex = 8;
            // 
            // txtMonto
            // 
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(264, 198);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(318, 21);
            this.txtMonto.TabIndex = 10;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(261, 167);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 17);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "Monto";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(264, 282);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 21);
            this.txtNombre.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(261, 251);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(253, 17);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre de quien realiza el movimiento";
            // 
            // btnConsultarMovimientos
            // 
            this.btnConsultarMovimientos.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnConsultarMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarMovimientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarMovimientos.Location = new System.Drawing.Point(25, 306);
            this.btnConsultarMovimientos.Name = "btnConsultarMovimientos";
            this.btnConsultarMovimientos.Size = new System.Drawing.Size(189, 59);
            this.btnConsultarMovimientos.TabIndex = 14;
            this.btnConsultarMovimientos.Text = "Consultar movimientos";
            this.btnConsultarMovimientos.UseVisualStyleBackColor = false;
            // 
            // btnRealizarMovimiento
            // 
            this.btnRealizarMovimiento.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRealizarMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRealizarMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarMovimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRealizarMovimiento.Location = new System.Drawing.Point(25, 222);
            this.btnRealizarMovimiento.Name = "btnRealizarMovimiento";
            this.btnRealizarMovimiento.Size = new System.Drawing.Size(189, 59);
            this.btnRealizarMovimiento.TabIndex = 13;
            this.btnRealizarMovimiento.Text = "Realizar movimiento";
            this.btnRealizarMovimiento.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(483, 345);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 33);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // FrmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 404);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultarMovimientos);
            this.Controls.Add(this.btnRealizarMovimiento);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClaveCuenta);
            this.Controls.Add(this.grpTipoMovimiento);
            this.Controls.Add(this.lbMovimientos);
            this.Name = "FrmMovimiento";
            this.Text = "FrmMovimientos";
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
        private System.Windows.Forms.Button btnConsultarMovimientos;
        private System.Windows.Forms.Button btnRealizarMovimiento;
        private System.Windows.Forms.Button btnLimpiar;
    }
}