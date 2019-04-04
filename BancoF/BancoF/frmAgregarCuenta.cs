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
    public partial class frmAgregarCuenta : Form
    {

        private ManejaCuentas manejaCuentas;
        private ManejaCatalogoCuenta manejaCatalogo;
        private int claveCliente;

        public frmAgregarCuenta(int claveCli,ManejaCuentas mCuentas, ManejaCatalogoCuenta mCatalogo)
        {
            this.manejaCuentas = mCuentas;
            this.manejaCatalogo = mCatalogo;
            this.claveCliente = claveCli;
            InitializeComponent();
        }

        private void frmAgregarCuenta_Load(object sender, EventArgs e)
        {
            cmbTipoCuenta.SelectedIndex = 0;

        }

        public void AgregarTiposCuentas()
        {
            string[] nombresCuentas = manejaCatalogo.obtieneNombres();

            foreach (string item in nombresCuentas)
                cmbTipoCuenta.Items.Add(item);
        }

        private void tsGuardarCuenta_Click(object sender, EventArgs e)
        {

        }

        public bool ValidaDatos()
        {
            bool flag = true;
            string claveCuenta = txtNumCuenta.Text;
            string tipoCuenta = cmbTipoCuenta.Text;
            string monto = msktxtMonto.Text;

            if (Rutinas.ValidaBlancos(claveCuenta))
            {
                MessageBox.Show("No se ha capturado el número de serie asignado a la cuenta.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                flag = false;
            }

            return flag;
 
        }
    }
}
