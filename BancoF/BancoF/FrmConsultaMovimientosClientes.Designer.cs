namespace BancoF
{
    partial class FrmConsultaMovimientosClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbCuentas = new System.Windows.Forms.ComboBox();
            this.lblNombreCMC = new System.Windows.Forms.Label();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveDeCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDiv = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.msConsultaMovimientosCliente = new System.Windows.Forms.MenuStrip();
            this.tsTecBank = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSaldoCuenta = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.lblDatosClientes2 = new System.Windows.Forms.Label();
            this.lblMovimientos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.msConsultaMovimientosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCuentas
            // 
            this.cmbCuentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCuentas.FormattingEnabled = true;
            this.cmbCuentas.Location = new System.Drawing.Point(623, 177);
            this.cmbCuentas.Name = "cmbCuentas";
            this.cmbCuentas.Size = new System.Drawing.Size(325, 21);
            this.cmbCuentas.TabIndex = 28;
            this.cmbCuentas.SelectedIndexChanged += new System.EventHandler(this.cmbCuentas_SelectedIndexChanged);
            // 
            // lblNombreCMC
            // 
            this.lblNombreCMC.AutoSize = true;
            this.lblNombreCMC.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCMC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.lblNombreCMC.Location = new System.Drawing.Point(24, 52);
            this.lblNombreCMC.Name = "lblNombreCMC";
            this.lblNombreCMC.Size = new System.Drawing.Size(179, 54);
            this.lblNombreCMC.TabIndex = 27;
            this.lblNombreCMC.Text = "Nombre";
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Tipo,
            this.ClaveDeCuenta,
            this.Importe,
            this.Nombre});
            this.dgvMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgvMovimientos.Location = new System.Drawing.Point(54, 244);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.Size = new System.Drawing.Size(906, 304);
            this.dgvMovimientos.TabIndex = 26;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // ClaveDeCuenta
            // 
            this.ClaveDeCuenta.HeaderText = "Clave cuenta";
            this.ClaveDeCuenta.Name = "ClaveDeCuenta";
            this.ClaveDeCuenta.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre de quien realizo el movimiento";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 380;
            // 
            // panelDiv
            // 
            this.panelDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.panelDiv.Location = new System.Drawing.Point(-6, 570);
            this.panelDiv.Name = "panelDiv";
            this.panelDiv.Size = new System.Drawing.Size(1052, 45);
            this.panelDiv.TabIndex = 29;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(976, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // msConsultaMovimientosCliente
            // 
            this.msConsultaMovimientosCliente.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.msConsultaMovimientosCliente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTecBank});
            this.msConsultaMovimientosCliente.Location = new System.Drawing.Point(0, 0);
            this.msConsultaMovimientosCliente.Name = "msConsultaMovimientosCliente";
            this.msConsultaMovimientosCliente.Size = new System.Drawing.Size(1000, 27);
            this.msConsultaMovimientosCliente.TabIndex = 31;
            this.msConsultaMovimientosCliente.Text = "menuStrip1";
            // 
            // tsTecBank
            // 
            this.tsTecBank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.tsTecBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsTecBank.Name = "tsTecBank";
            this.tsTecBank.Size = new System.Drawing.Size(77, 23);
            this.tsTecBank.Text = "TecBank";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // lblSaldoCuenta
            // 
            this.lblSaldoCuenta.AutoSize = true;
            this.lblSaldoCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoCuenta.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCuenta.Location = new System.Drawing.Point(122, 175);
            this.lblSaldoCuenta.Name = "lblSaldoCuenta";
            this.lblSaldoCuenta.Size = new System.Drawing.Size(20, 25);
            this.lblSaldoCuenta.TabIndex = 33;
            this.lblSaldoCuenta.Text = "-";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldo.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(49, 175);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(67, 25);
            this.lblSaldo.TabIndex = 32;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosCliente.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.lblDatosCliente.Location = new System.Drawing.Point(49, 118);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(15, 19);
            this.lblDatosCliente.TabIndex = 34;
            this.lblDatosCliente.Text = "-";
            // 
            // lblDatosClientes2
            // 
            this.lblDatosClientes2.AutoSize = true;
            this.lblDatosClientes2.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosClientes2.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosClientes2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.lblDatosClientes2.Location = new System.Drawing.Point(50, 144);
            this.lblDatosClientes2.Name = "lblDatosClientes2";
            this.lblDatosClientes2.Size = new System.Drawing.Size(15, 19);
            this.lblDatosClientes2.TabIndex = 35;
            this.lblDatosClientes2.Text = "-";
            // 
            // lblMovimientos
            // 
            this.lblMovimientos.AutoSize = true;
            this.lblMovimientos.BackColor = System.Drawing.Color.Transparent;
            this.lblMovimientos.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimientos.Location = new System.Drawing.Point(49, 216);
            this.lblMovimientos.Name = "lblMovimientos";
            this.lblMovimientos.Size = new System.Drawing.Size(101, 21);
            this.lblMovimientos.TabIndex = 36;
            this.lblMovimientos.Text = "Movimientos";
            // 
            // FrmConsultaMovimientosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblMovimientos);
            this.Controls.Add(this.lblDatosClientes2);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.lblSaldoCuenta);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbCuentas);
            this.Controls.Add(this.lblNombreCMC);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.panelDiv);
            this.Controls.Add(this.msConsultaMovimientosCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultaMovimientosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaMovimientosClientes";
            this.Load += new System.EventHandler(this.FrmConsultaMovimientosClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.msConsultaMovimientosCliente.ResumeLayout(false);
            this.msConsultaMovimientosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCuentas;
        private System.Windows.Forms.Label lblNombreCMC;
        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveDeCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Panel panelDiv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip msConsultaMovimientosCliente;
        private System.Windows.Forms.ToolStripMenuItem tsTecBank;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblSaldoCuenta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Label lblDatosClientes2;
        private System.Windows.Forms.Label lblMovimientos;
    }
}