namespace BancoF
{
    partial class frnVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frnVentanaPrincipal));
            this.btnMovimientos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnCuentasBanco = new System.Windows.Forms.Button();
            this.lblTecBank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMovimientos
            // 
            this.btnMovimientos.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimientos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMovimientos.Location = new System.Drawing.Point(52, 224);
            this.btnMovimientos.Name = "btnMovimientos";
            this.btnMovimientos.Size = new System.Drawing.Size(392, 59);
            this.btnMovimientos.TabIndex = 0;
            this.btnMovimientos.Text = "Movimientos";
            this.btnMovimientos.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClientes.Location = new System.Drawing.Point(52, 300);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(392, 59);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnCuentas
            // 
            this.btnCuentas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuentas.Location = new System.Drawing.Point(52, 374);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(392, 59);
            this.btnCuentas.TabIndex = 2;
            this.btnCuentas.Text = "Cuentas";
            this.btnCuentas.UseVisualStyleBackColor = false;
            // 
            // btnCuentasBanco
            // 
            this.btnCuentasBanco.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCuentasBanco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCuentasBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentasBanco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCuentasBanco.Location = new System.Drawing.Point(52, 474);
            this.btnCuentasBanco.Name = "btnCuentasBanco";
            this.btnCuentasBanco.Size = new System.Drawing.Size(392, 59);
            this.btnCuentasBanco.TabIndex = 3;
            this.btnCuentasBanco.Text = "Cuentas Banco";
            this.btnCuentasBanco.UseVisualStyleBackColor = false;
            // 
            // lblTecBank
            // 
            this.lblTecBank.AutoSize = true;
            this.lblTecBank.Font = new System.Drawing.Font("Arial", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblTecBank.Location = new System.Drawing.Point(99, 78);
            this.lblTecBank.Name = "lblTecBank";
            this.lblTecBank.Size = new System.Drawing.Size(305, 78);
            this.lblTecBank.TabIndex = 4;
            this.lblTecBank.Text = "TecBank";
            // 
            // frnVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 562);
            this.Controls.Add(this.lblTecBank);
            this.Controls.Add(this.btnCuentasBanco);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnMovimientos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frnVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovimientos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnCuentasBanco;
        private System.Windows.Forms.Label lblTecBank;
    }
}

