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
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir de TecBank?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
