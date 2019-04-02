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
    public partial class frnVentanaPrincipal : Form
    { 

        public frnVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void frnVentanaPrincipal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblFecha.Text = Convert.ToString(fecha);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void realizarMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimiento frmMovimiento = new FrmMovimiento();
            frmMovimiento.ShowDialog();
        }
    }
}
