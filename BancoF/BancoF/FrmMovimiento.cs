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
    public partial class FrmMovimiento : Form
    {
        public FrmMovimiento()
        {
            InitializeComponent();
        }

        private void FrmMovimiento_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void realizarMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                epMovimiento.SetError(txtMonto, "SOLO SE PERMITEN NUMEROS");
                e.Handled = true;
            }
            else
            {
                epMovimiento.SetError(txtMonto, "");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                epMovimiento.SetError(txtNombre, "SOLO SE PERMITE TEXTO");
                e.Handled = true;
            }
            else
            {
                epMovimiento.SetError(txtNombre, "");
            }
        }
    }
}
