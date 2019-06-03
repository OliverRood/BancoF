namespace BancoF
{
    partial class frmEjecutivo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHola = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTecBank = new System.Windows.Forms.Label();
            this.msEjecutivo = new System.Windows.Forms.MenuStrip();
            this.tsBank = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarCesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAgregarCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.msEjecutivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Ebrima", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblNombre.Location = new System.Drawing.Point(468, 227);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(355, 95);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Bienvenido";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.BackColor = System.Drawing.Color.Transparent;
            this.lblHola.Font = new System.Drawing.Font("Ebrima", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.lblHola.Location = new System.Drawing.Point(471, 165);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(128, 75);
            this.lblHola.TabIndex = 14;
            this.lblHola.Text = "Hola";
            this.lblHola.Click += new System.EventHandler(this.lblHola_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFecha.Location = new System.Drawing.Point(254, 393);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(10, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "-";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BancoF.Properties.Resources.shopping_store;
            this.pictureBox1.Location = new System.Drawing.Point(248, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTecBank
            // 
            this.lblTecBank.AutoSize = true;
            this.lblTecBank.BackColor = System.Drawing.Color.Transparent;
            this.lblTecBank.Font = new System.Drawing.Font("Ebrima", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.lblTecBank.Location = new System.Drawing.Point(178, 306);
            this.lblTecBank.Name = "lblTecBank";
            this.lblTecBank.Size = new System.Drawing.Size(251, 85);
            this.lblTecBank.TabIndex = 11;
            this.lblTecBank.Text = "TecBank";
            this.lblTecBank.Click += new System.EventHandler(this.lblTecBank_Click);
            // 
            // msEjecutivo
            // 
            this.msEjecutivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.msEjecutivo.Font = new System.Drawing.Font("Ebrima", 10F);
            this.msEjecutivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBank,
            this.tsCuenta,
            this.tsBanco});
            this.msEjecutivo.Location = new System.Drawing.Point(0, 0);
            this.msEjecutivo.Name = "msEjecutivo";
            this.msEjecutivo.Padding = new System.Windows.Forms.Padding(7, 5, 0, 2);
            this.msEjecutivo.Size = new System.Drawing.Size(1000, 33);
            this.msEjecutivo.TabIndex = 16;
            this.msEjecutivo.Text = "menuStrip1";
            // 
            // tsBank
            // 
            this.tsBank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.cerrarCesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.tsBank.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.tsBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsBank.Name = "tsBank";
            this.tsBank.Size = new System.Drawing.Size(78, 26);
            this.tsBank.Text = "TecBank";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.acercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // cerrarCesionToolStripMenuItem
            // 
            this.cerrarCesionToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.cerrarCesionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.cerrarCesionToolStripMenuItem.Name = "cerrarCesionToolStripMenuItem";
            this.cerrarCesionToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.cerrarCesionToolStripMenuItem.Text = "Cerrar sesion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // tsCuenta
            // 
            this.tsCuenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAgregarCuenta,
            this.cerrarCuentaToolStripMenuItem});
            this.tsCuenta.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.tsCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsCuenta.Name = "tsCuenta";
            this.tsCuenta.Size = new System.Drawing.Size(74, 26);
            this.tsCuenta.Text = "Cuentas";
            // 
            // tsAgregarCuenta
            // 
            this.tsAgregarCuenta.Font = new System.Drawing.Font("Ebrima", 10F);
            this.tsAgregarCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.tsAgregarCuenta.Name = "tsAgregarCuenta";
            this.tsAgregarCuenta.Size = new System.Drawing.Size(184, 26);
            this.tsAgregarCuenta.Text = "Aperturar cuenta";
            // 
            // cerrarCuentaToolStripMenuItem
            // 
            this.cerrarCuentaToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.cerrarCuentaToolStripMenuItem.Name = "cerrarCuentaToolStripMenuItem";
            this.cerrarCuentaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.cerrarCuentaToolStripMenuItem.Text = "Cerrar cuenta";
            // 
            // tsBanco
            // 
            this.tsBanco.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteToolStripMenuItem});
            this.tsBanco.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.tsBanco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsBanco.Name = "tsBanco";
            this.tsBanco.Size = new System.Drawing.Size(63, 26);
            this.tsBanco.Text = "Banco";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasToolStripMenuItem,
            this.movimientosToolStripMenuItem});
            this.reporteToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // frmEjecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.msEjecutivo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblHola);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTecBank);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEjecutivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecBank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.msEjecutivo.ResumeLayout(false);
            this.msEjecutivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTecBank;
        private System.Windows.Forms.MenuStrip msEjecutivo;
        private System.Windows.Forms.ToolStripMenuItem tsBank;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cerrarCesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCuenta;
        private System.Windows.Forms.ToolStripMenuItem tsAgregarCuenta;
        private System.Windows.Forms.ToolStripMenuItem tsBanco;
        private System.Windows.Forms.ToolStripMenuItem cerrarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
    }
}