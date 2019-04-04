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
    public partial class FrmCuentasBanco : Form
    {
        public FrmCuentasBanco()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar != (char) Keys.Back)
            {
                epCuentasBanco.SetError(txtNombre, "SOLO SE PERMITE TEXTO");
                e.Handled = true;
            }
            else
            {
                epCuentasBanco.SetError(txtNombre, "");
            }
        }

        private void txtMontoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                epCuentasBanco.SetError(txtMontoMinimo, "SOLO SE PERMITEN NUMEROS");
                e.Handled = true;
            }
            else
            {
                epCuentasBanco.SetError(txtMontoMinimo, "");
            }
        }

        private void FrmCuentasBanco_Load(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                epCuentasBanco.SetError(txtDescripcion, "SOLO SE PERMITE TEXTO");
                e.Handled = true;
            }
            else
            {
                epCuentasBanco.SetError(txtDescripcion, "");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtMontoMinimo.Clear();
            txtDescripcion.Clear();
        }
    }
}
