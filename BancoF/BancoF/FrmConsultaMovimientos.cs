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
    public partial class FrmConsultaMovimientos : Form
    {

        ManejaMovimiento manejaMovimiento;

        public FrmConsultaMovimientos(ManejaMovimiento manejaMovimiento)
        {
            this.manejaMovimiento = manejaMovimiento;
            InitializeComponent();
        }

        private void FrmConsultaMovimientos_Load(object sender, EventArgs e)
        {
            Movimiento[] movimientos = manejaMovimiento.obtieneMovimientos();
            foreach (Movimiento item in movimientos)
            {
                if (item != null) dgvMovimientos.Rows.Add(item.pFecha, item.pHora, ((item.pTipo == 'D') ? "DEPOSITO" : "RETIRO"), item.pClaveCuenta, item.pImporte, item.pNombreRealizo);
            }
        }

        private void tsCerrarMovimientos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void msMovimientos_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
