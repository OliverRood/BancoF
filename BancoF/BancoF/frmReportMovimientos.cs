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
    public partial class frmReportMovimientos : Form
    {
        public frmReportMovimientos()
        {
            InitializeComponent();
        }

        private void frmReportMovimientos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetMovimientos.Movimiento' table. You can move, or remove it, as needed.
            this.MovimientoTableAdapter.Fill(this.DataSetMovimientos.Movimiento);

            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarReporteMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
