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
            this.tabMovimiento = new System.Windows.Forms.TabControl();
            this.tabDeposito = new System.Windows.Forms.TabPage();
            this.tabRetiro = new System.Windows.Forms.TabPage();
            this.tabMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMovimientos
            // 
            this.lbMovimientos.AutoSize = true;
            this.lbMovimientos.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbMovimientos.Location = new System.Drawing.Point(19, 23);
            this.lbMovimientos.Name = "lbMovimientos";
            this.lbMovimientos.Size = new System.Drawing.Size(183, 32);
            this.lbMovimientos.TabIndex = 5;
            this.lbMovimientos.Text = "Movimientos";
            // 
            // tabMovimiento
            // 
            this.tabMovimiento.Controls.Add(this.tabDeposito);
            this.tabMovimiento.Controls.Add(this.tabRetiro);
            this.tabMovimiento.Location = new System.Drawing.Point(25, 74);
            this.tabMovimiento.Name = "tabMovimiento";
            this.tabMovimiento.SelectedIndex = 0;
            this.tabMovimiento.Size = new System.Drawing.Size(742, 284);
            this.tabMovimiento.TabIndex = 6;
            // 
            // tabDeposito
            // 
            this.tabDeposito.Location = new System.Drawing.Point(4, 22);
            this.tabDeposito.Name = "tabDeposito";
            this.tabDeposito.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposito.Size = new System.Drawing.Size(734, 258);
            this.tabDeposito.TabIndex = 0;
            this.tabDeposito.Text = "Deposito";
            this.tabDeposito.UseVisualStyleBackColor = true;
            // 
            // tabRetiro
            // 
            this.tabRetiro.Location = new System.Drawing.Point(4, 22);
            this.tabRetiro.Name = "tabRetiro";
            this.tabRetiro.Padding = new System.Windows.Forms.Padding(3);
            this.tabRetiro.Size = new System.Drawing.Size(734, 258);
            this.tabRetiro.TabIndex = 1;
            this.tabRetiro.Text = "Retiro";
            this.tabRetiro.UseVisualStyleBackColor = true;
            // 
            // FrmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMovimiento);
            this.Controls.Add(this.lbMovimientos);
            this.Name = "FrmMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMovimientos";
            this.Load += new System.EventHandler(this.FrmMovimiento_Load);
            this.tabMovimiento.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMovimientos;
        private System.Windows.Forms.TabControl tabMovimiento;
        private System.Windows.Forms.TabPage tabDeposito;
        private System.Windows.Forms.TabPage tabRetiro;
    }
}