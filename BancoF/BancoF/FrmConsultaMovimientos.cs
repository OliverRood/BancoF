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
        bool flagDisplay;

        public FrmConsultaMovimientos(ManejaMovimiento manejaMovimiento, ManejaCliente manejaCliente, ManejaCuentas manejaCuentas, string nombreCliente, bool flagDisplay)
        {
            this.manejaMovimiento = manejaMovimiento;
            this.manejaCliente = manejaCliente;
            this.manejaCuentas = manejaCuentas;
            this.nombreCliente = nombreCliente;
            this.flagDisplay = flagDisplay;
            InitializeComponent();
        }

        private void FrmConsultaMovimientos_Load(object sender, EventArgs e)
        {
            int claveCliente = manejaCliente.KeyCliente(nombreCliente);
            cuentasCliente = manejaCuentas.ObtenerPorCliente(claveCliente);
            foreach (KeyValuePair<int, Cuenta> item in cuentasCliente)
            {
                if (item.Value.pClaveCliente == claveCliente)
                {
                    cmbCuentas.Items.Add(item.Key);
                }
            }
            movimientosPorCliente = manejaMovimiento.obtieneMovimientosPorCliente(claveCliente);
            foreach (Movimiento item in movimientosPorCliente)
            {
                dgvMovimientos.Rows.Add(item.pFecha, item.pTipo, item.pClaveCuenta, item.pImporte, item.pNombreDepositador);
            }
            if (flagDisplay) cmbCuentas.Visible=false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbNombresClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cuentaCmb = Convert.ToString(cmbCuentas.SelectedItem);
            for (int i = 0; i < movimientosPorCliente.Length; i++)
            {
                if (dgvMovimientos.Rows[i].Cells[2].ToString().Equals(cuentaCmb))
                {
                    dgvMovimientos.Rows[i].Visible = false;
                }
            }
        }
    }
}
