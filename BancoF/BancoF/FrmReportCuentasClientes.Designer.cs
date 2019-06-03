namespace BancoF
{
    partial class FrmReportCuentasClientes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCuentasClientes = new BancoF.DataSetCuentasClientes();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tecBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CuentaTableAdapter = new BancoF.DataSetCuentasClientesTableAdapters.CuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCuentasClientes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CuentaBindingSource
            // 
            this.CuentaBindingSource.DataMember = "Cuenta";
            this.CuentaBindingSource.DataSource = this.DataSetCuentasClientes;
            // 
            // DataSetCuentasClientes
            // 
            this.DataSetCuentasClientes.DataSetName = "DataSetCuentasClientes";
            this.DataSetCuentasClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tecBankToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tecBankToolStripMenuItem
            // 
            this.tecBankToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCerrar,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.tecBankToolStripMenuItem.Name = "tecBankToolStripMenuItem";
            this.tecBankToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.tecBankToolStripMenuItem.Text = "TecBank";
            // 
            // tsCerrar
            // 
            this.tsCerrar.Font = new System.Drawing.Font("Ebrima", 10F);
            this.tsCerrar.Name = "tsCerrar";
            this.tsCerrar.Size = new System.Drawing.Size(224, 26);
            this.tsCerrar.Text = "Cerrar reportes cuentas";
            this.tsCerrar.Click += new System.EventHandler(this.tsCerrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(975, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCuentas";
            reportDataSource1.Value = this.CuentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BancoF.ReportCuentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 570);
            this.reportViewer1.TabIndex = 11;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // CuentaTableAdapter
            // 
            this.CuentaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReportCuentasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReportCuentasClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCuentasClientes";
            this.Load += new System.EventHandler(this.FrmCuentasClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCuentasClientes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tecBankToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsCerrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CuentaBindingSource;
        private DataSetCuentasClientes DataSetCuentasClientes;
        private DataSetCuentasClientesTableAdapters.CuentaTableAdapter CuentaTableAdapter;
    }
}