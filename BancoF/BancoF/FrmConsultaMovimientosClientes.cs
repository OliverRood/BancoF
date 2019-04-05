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
    public partial class FrmConsultaMovimientosClientes : Form
    {
        ManejaMovimiento manejaMovimiento;
        ManejaCliente manejaCliente;
        ManejaCuentas manejaCuentas;
        KeyValuePair<int, Cuenta>[] cuentasCliente;
        Movimiento[] movimientosPorCliente;
        string nombreCliente;
        bool DisplayIndicator; // True: Cmb Visible

        public FrmConsultaMovimientosClientes(ManejaMovimiento manejaMovimiento, ManejaCliente manejaCliente, ManejaCuentas manejaCuentas, string nombreCliente, bool DisplayIndicator)
        {
            this.manejaMovimiento = manejaMovimiento;
            this.manejaCliente = manejaCliente;
            this.manejaCuentas = manejaCuentas;
            this.nombreCliente = nombreCliente;
            this.DisplayIndicator = DisplayIndicator;
            InitializeComponent();
        }


        private void FrmConsultaMovimientosClientes_Load(object sender, EventArgs e)
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
            movimientosPorCliente = manejaMovimiento.obtieneMovimientos();
            if (!DisplayIndicator) {
                cmbCuentas.Visible = false;
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
            }
            Cliente temp = manejaCliente.ObtenerCliente(claveCliente);
            lblNombreCMC.Text = temp.pNombre;
            lblSaldoCuenta.Text = "$" + manejaCuentas.obtenerSaldoTotalPorCliente(claveCliente) + " MXN";
            lblDatosCliente.Text = "Domicilio: " + temp.pDomicilio + "     Ciudad: " + temp.pCiudad;
            lblDatosClientes2.Text = "Telefono: " + temp.pTelefono;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvMovimientos.Rows.Clear();
            dgvMovimientos.Refresh();
            int cuentaCmb = Convert.ToInt32(cmbCuentas.SelectedItem.ToString());
            foreach (Movimiento item in movimientosPorCliente)
            {
                if (item != null)
                {
                    if (item.pClaveCuenta == cuentaCmb)
                    {
                        dgvMovimientos.Rows.Add(item.pFecha, item.pTipo, item.pClaveCuenta, item.pImporte, item.pNombreDepositador);
                    }
                }
            }
        }
        
    }
}
