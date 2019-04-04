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
        int DisplayIndicator; // 1.- Por cuenta 2.- Todo (Movimientos del cliente) 3.- Movimientos (Todos los movimientos en el banco)

        public FrmConsultaMovimientos(ManejaMovimiento manejaMovimiento, ManejaCliente manejaCliente, ManejaCuentas manejaCuentas, string nombreCliente, int DisplayIndicator)
        {
            this.manejaMovimiento = manejaMovimiento;
            this.manejaCliente = manejaCliente;
            this.manejaCuentas = manejaCuentas;
            this.nombreCliente = nombreCliente;
            this.DisplayIndicator = DisplayIndicator;
            InitializeComponent();
        }

        private void FrmConsultaMovimientos_Load(object sender, EventArgs e)
        {
            switch (DisplayIndicator)
            {
                case 1:
                case 2:
                    int claveCliente = manejaCliente.KeyCliente(nombreCliente);
                    cuentasCliente = manejaCuentas.ObtenerPorCliente(claveCliente);
                    foreach (KeyValuePair<int, Cuenta> item in cuentasCliente)
                    {
                        if (item.Value.pClaveCliente == claveCliente)
                        {
                            cmbCuentas.Items.Add(item.Key);
                        }
                    }
                    movimientosPorCliente = manejaMovimiento.obtieneMovimientos();
                    foreach (Movimiento item in movimientosPorCliente)
                    {
                        if (item != null)
                        {
                            for (int i = 0; i < cuentasCliente.Length; i++)
                            {
                                if (item.pClaveCuenta == cuentasCliente[i].Key)
                                {
                                    dgvMovimientos.Rows.Add(item.pFecha, item.pTipo, item.pClaveCuenta, item.pImporte, item.pNombreDepositador);
                                }
                            }
                        }
                    }
                    break;
                case 3:
                    Movimiento[] movimientos = manejaMovimiento.obtieneMovimientos();
                    foreach (Movimiento item in movimientos)
                    {
                        if (item != null) dgvMovimientos.Rows.Add(item.pFecha, item.pTipo, item.pClaveCuenta, item.pImporte, item.pNombreDepositador);
                    }
                    break;
                default:
                    break;
            }
            if (DisplayIndicator!=1) cmbCuentas.Visible=false;
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
                if (dgvMovimientos.Rows[i].Cells[3].Value.Equals(cuentaCmb))
                {
                    dgvMovimientos.Rows[i].Visible = false;
                }
            }
        }
    }
}
