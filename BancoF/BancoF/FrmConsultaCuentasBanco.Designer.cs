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
            this.lbCuentasBanco = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMontoMinimo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreSelected = new System.Windows.Forms.Label();
            this.lblMontoMInimoSelected = new System.Windows.Forms.Label();
            this.lblDescripcionSelected = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCuentasBanco
            // 
            this.lbCuentasBanco.AutoSize = true;
            this.lbCuentasBanco.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCuentasBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbCuentasBanco.Location = new System.Drawing.Point(23, 41);
            this.lbCuentasBanco.Name = "lbCuentasBanco";
            this.lbCuentasBanco.Size = new System.Drawing.Size(215, 32);
            this.lbCuentasBanco.TabIndex = 7;
            this.lbCuentasBanco.Text = "Cuentas Banco";
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(445, 52);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(227, 21);
            this.cmbNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(74, 151);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMontoMinimo
            // 
            this.lblMontoMinimo.AutoSize = true;
            this.lblMontoMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMinimo.Location = new System.Drawing.Point(74, 224);
            this.lblMontoMinimo.Name = "lblMontoMinimo";
            this.lblMontoMinimo.Size = new System.Drawing.Size(116, 18);
            this.lblMontoMinimo.TabIndex = 15;
            this.lblMontoMinimo.Text = "Monto Minimo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(74, 292);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 18);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombreSelected
            // 
            this.lblNombreSelected.AutoSize = true;
            this.lblNombreSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSelected.Location = new System.Drawing.Point(281, 151);
            this.lblNombreSelected.Name = "lblNombreSelected";
            this.lblNombreSelected.Size = new System.Drawing.Size(23, 18);
            this.lblNombreSelected.TabIndex = 17;
            this.lblNombreSelected.Text = "---";
            // 
            // lblMontoMInimoSelected
            // 
            this.lblMontoMInimoSelected.AutoSize = true;
            this.lblMontoMInimoSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoMInimoSelected.Location = new System.Drawing.Point(281, 224);
            this.lblMontoMInimoSelected.Name = "lblMontoMInimoSelected";
            this.lblMontoMInimoSelected.Size = new System.Drawing.Size(23, 18);
            this.lblMontoMInimoSelected.TabIndex = 18;
            this.lblMontoMInimoSelected.Text = "---";
            // 
            // lblDescripcionSelected
            // 
            this.lblDescripcionSelected.AutoSize = true;
            this.lblDescripcionSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionSelected.Location = new System.Drawing.Point(281, 292);
            this.lblDescripcionSelected.Name = "lblDescripcionSelected";
            this.lblDescripcionSelected.Size = new System.Drawing.Size(23, 18);
            this.lblDescripcionSelected.TabIndex = 19;
            this.lblDescripcionSelected.Text = "---";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisor.Location = new System.Drawing.Point(56, 92);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(616, 18);
            this.lblDivisor.TabIndex = 20;
            this.lblDivisor.Text = "____________________________________________________________________________";
            // 
            // FrmConsultaCuentasBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 428);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDescripcionSelected);
            this.Controls.Add(this.lblMontoMInimoSelected);
            this.Controls.Add(this.lblNombreSelected);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblMontoMinimo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.lbCuentasBanco);
            this.Name = "FrmConsultaCuentasBanco";
            this.Text = "FrmConsultaCuentasBanco";
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
        private System.Windows.Forms.Label lblDivisor;
    }
}