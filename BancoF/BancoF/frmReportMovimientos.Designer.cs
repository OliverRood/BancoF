namespace BancoF
{
    partial class frmReportMovimientos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetMovimientos = new BancoF.DataSetMovimientos();
            this.MovimientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MovimientoTableAdapter = new BancoF.DataSetMovimientosTableAdapters.MovimientoTableAdapter();
            this.msRM = new System.Windows.Forms.MenuStrip();
            this.tsBank = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cerrarReporteMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMovimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoBindingSource)).BeginInit();
            this.msRM.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "dsMovimientos";
            reportDataSource4.Value = this.MovimientoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BancoF.rMovimientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 33);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 568);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetMovimientos
            // 
            this.DataSetMovimientos.DataSetName = "DataSetMovimientos";
            this.DataSetMovimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MovimientoBindingSource
            // 
            this.MovimientoBindingSource.DataMember = "Movimiento";
            this.MovimientoBindingSource.DataSource = this.DataSetMovimientos;
            // 
            // MovimientoTableAdapter
            // 
            this.MovimientoTableAdapter.ClearBeforeFill = true;
            // 
            // msRM
            // 
            this.msRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.msRM.Font = new System.Drawing.Font("Ebrima", 10F);
            this.msRM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBank});
            this.msRM.Location = new System.Drawing.Point(0, 0);
            this.msRM.Name = "msRM";
            this.msRM.Padding = new System.Windows.Forms.Padding(7, 5, 0, 2);
            this.msRM.Size = new System.Drawing.Size(1000, 30);
            this.msRM.TabIndex = 6;
            this.msRM.Text = "menuStrip1";
            // 
            // tsBank
            // 
            this.tsBank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarReporteMovimientosToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.tsBank.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.tsBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsBank.Name = "tsBank";
            this.tsBank.Size = new System.Drawing.Size(77, 23);
            this.tsBank.Text = "TecBank";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(972, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cerrarReporteMovimientosToolStripMenuItem
            // 
            this.cerrarReporteMovimientosToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.cerrarReporteMovimientosToolStripMenuItem.Name = "cerrarReporteMovimientosToolStripMenuItem";
            this.cerrarReporteMovimientosToolStripMenuItem.Size = new System.Drawing.Size(248, 24);
            this.cerrarReporteMovimientosToolStripMenuItem.Text = "Cerrar reporte movimientos";
            this.cerrarReporteMovimientosToolStripMenuItem.Click += new System.EventHandler(this.cerrarReporteMovimientosToolStripMenuItem_Click);
            // 
            // frmReportMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.msRM);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportMovimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportMovimientos";
            this.Load += new System.EventHandler(this.frmReportMovimientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMovimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientoBindingSource)).EndInit();
            this.msRM.ResumeLayout(false);
            this.msRM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MovimientoBindingSource;
        private DataSetMovimientos DataSetMovimientos;
        private DataSetMovimientosTableAdapters.MovimientoTableAdapter MovimientoTableAdapter;
        private System.Windows.Forms.MenuStrip msRM;
        private System.Windows.Forms.ToolStripMenuItem tsBank;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem cerrarReporteMovimientosToolStripMenuItem;
    }
}