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
        ManejaCliente manejaCliente;
        ManejaCuentas manejaCuentas;
        KeyValuePair<int, Cuenta>[] cuentasCliente;
        Movimiento[] movimientosPorCliente;
        string nombreCliente;

        public FrmConsultaMovimientos(ManejaMovimiento manejaMovimiento, ManejaCliente manejaCliente, ManejaCuentas manejaCuentas, string nombreCliente)
        {
            this.manejaMovimiento = manejaMovimiento;
            this.manejaCliente = manejaCliente;
            this.manejaCuentas = manejaCuentas;
            this.nombreCliente = nombreCliente;
            InitializeComponent();
        }

        private void FrmConsultaMovimientos_Load(object sender, EventArgs e)
        {
            Movimiento[] movimientos = manejaMovimiento.obtieneMovimientos();
            foreach (Movimiento item in movimientos)
            {
                if (item != null) dgvMovimientos.Rows.Add(item.pFecha, item.pTipo, item.pClaveCuenta, item.pImporte, item.pNombreDepositador);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
