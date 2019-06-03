using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoF
{
    public partial class FrmReportCuentasClientes : Form
    {
        public FrmReportCuentasClientes()
        {
            InitializeComponent();
        }

        private void cerrarReporteMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmCuentasClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetCuentasClientes.Cuenta' Puede moverla o quitarla según sea necesario.
            this.CuentaTableAdapter.Fill(this.DataSetCuentasClientes.Cuenta);

            this.reportViewer1.RefreshReport();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
