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
            AgregarTiposCuentas();
            cmbTipoCuenta.SelectedIndex = 0;
        }

        public void AgregarTiposCuentas()
        {
            string[] nombresCuentas = manejaCatalogo.obtieneNombres();

            foreach (string item in nombresCuentas)
            {
                if(item!=null) cmbTipoCuenta.Items.Add(item);
            }
        }

        private void tsGuardarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea guardar los datos de la cuenta?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)

             try
             {
                string claveCuenta = txtNumCuenta.Text;
                string tipoCu = cmbTipoCuenta.Text;
                double monto = Convert.ToDouble(txtMontoApertura.Text);

                if (ValidaDatos())
                {
                    manejaCuentas.Agrega(Convert.ToInt32(claveCuenta), claveCliente, monto, tipoCu);
                    MessageBox.Show("Cuenta agregada con exito.", "Nueva cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Monto de apertura con formato incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ValidaDatos()
        {
            bool flag = true;
            string claveCuenta = txtNumCuenta.Text;
            string tipoCuenta = cmbTipoCuenta.Text;
            string monto = txtMontoApertura.Text;
            TipoCuenta temp = manejaCatalogo.consulta(tipoCuenta);

            if (Rutinas.ValidaBlancos(claveCuenta))
            {
                MessageBox.Show("No se ha capturado el número de serie asignado a la cuenta.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                flag = false;
            }

            if (Rutinas.ValidaNumCuenta(claveCuenta))
            {
                MessageBox.Show("Clave de cuenta con formato incorrecto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            if (manejaCuentas.BuscarCuenta(Convert.ToInt32(claveCuenta))!=null)
            {
                MessageBox.Show("La clave que desea asignarle a la cuenta ya está en existencia, intente con uno distinto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            if (cmbTipoCuenta.SelectedIndex==0)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cuenta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            if (Convert.ToDouble(monto) < temp.pMontoMinimo)
            {
                MessageBox.Show("El monto de apertura es menor al monto minimo requerido para el tipo de cuenta seleccionado.", "Aviso",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            /*if (Rutinas.ValidaBlancos(monto))
            {
                MessageBox.Show("No se ha capturado el monto de la cuenta a aperturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }*/

            return flag;
 
        }

        private void limpiar()
        {
            txtMontoApertura.Text = "";
            txtNumCuenta.Text = "";
            cmbTipoCuenta.SelectedIndex = 0;
        }

        private void txtNumCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber)(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
