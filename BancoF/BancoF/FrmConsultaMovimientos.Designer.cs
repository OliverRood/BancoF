namespace BancoF
{
    partial class FrmConsultaMovimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaMovimientos));
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.lbMovimientos = new System.Windows.Forms.Label();
            this.msMovimientos = new System.Windows.Forms.MenuStrip();
            this.tsTecBank = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrarMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panelDiv = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaveDeCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.msMovimientos.SuspendLayout();
            this.SuspendLayout();
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
            this.Hora,
            this.Tipo,
            this.ClaveDeCuenta,
            this.Importe,
            this.Nombre});
            this.dgvMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.dgvMovimientos.Location = new System.Drawing.Point(60, 138);
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.Size = new System.Drawing.Size(906, 420);
            this.dgvMovimientos.TabIndex = 0;
            // 
            // lbMovimientos
            // 
            this.lbMovimientos.AutoSize = true;
            this.lbMovimientos.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovimientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.lbMovimientos.Location = new System.Drawing.Point(20, 70);
            this.lbMovimientos.Name = "lbMovimientos";
            this.lbMovimientos.Size = new System.Drawing.Size(270, 54);
            this.lbMovimientos.TabIndex = 6;
            this.lbMovimientos.Text = "Movimientos";
            // 
            // msMovimientos
            // 
            this.msMovimientos.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.msMovimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTecBank});
            this.msMovimientos.Location = new System.Drawing.Point(0, 0);
            this.msMovimientos.Name = "msMovimientos";
            this.msMovimientos.Size = new System.Drawing.Size(1000, 27);
            this.msMovimientos.TabIndex = 23;
            this.msMovimientos.Text = "menuStrip1";
            this.msMovimientos.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msMovimientos_ItemClicked);
            // 
            // tsTecBank
            // 
            this.tsTecBank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCerrarMovimientos,
            this.toolStripSeparator1,
            this.tsSalir});
            this.tsTecBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsTecBank.Name = "tsTecBank";
            this.tsTecBank.Size = new System.Drawing.Size(77, 23);
            this.tsTecBank.Text = "TecBank";
            // 
            // tsCerrarMovimientos
            // 
            this.tsCerrarMovimientos.Font = new System.Drawing.Font("Ebrima", 10F);
            this.tsCerrarMovimientos.Name = "tsCerrarMovimientos";
            this.tsCerrarMovimientos.Size = new System.Drawing.Size(200, 24);
            this.tsCerrarMovimientos.Text = "Cerrar Movimientos";
            this.tsCerrarMovimientos.Click += new System.EventHandler(this.tsCerrarMovimientos_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // tsSalir
            // 
            this.tsSalir.Font = new System.Drawing.Font("Ebrima", 10F);
            this.tsSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.tsSalir.Size = new System.Drawing.Size(200, 24);
            this.tsSalir.Text = "Salir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // panelDiv
            // 
            this.panelDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.panelDiv.Location = new System.Drawing.Point(0, 574);
            this.panelDiv.Name = "panelDiv";
            this.panelDiv.Size = new System.Drawing.Size(1052, 45);
            this.panelDiv.TabIndex = 25;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(975, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
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
            this.Nombre.HeaderText = "Nombre de quien realizo";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 280;
            // 
            // FrmConsultaMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbMovimientos);
            this.Controls.Add(this.dgvMovimientos);
            this.Controls.Add(this.panelDiv);
            this.Controls.Add(this.msMovimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultaMovimientos";
            this.Load += new System.EventHandler(this.FrmConsultaMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.msMovimientos.ResumeLayout(false);
            this.msMovimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Label lbMovimientos;
        private System.Windows.Forms.MenuStrip msMovimientos;
        private System.Windows.Forms.ToolStripMenuItem tsTecBank;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.Panel panelDiv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem tsCerrarMovimientos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveDeCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}