using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RutinasDLL;
using System.Windows.Forms;

namespace BancoF
{
    public partial class frmAgregarCuenta : Form
    {

        private ManejaCuentas manejaCuentas;
        private ManejaCatalogoCuenta manejaCatalogo;
        private int claveCliente;

        public frmAgregarCuenta(ManejaCuentas mCuentas, ManejaCatalogoCuenta mCatalogo)
        {
            this.manejaCuentas = mCuentas;
            this.manejaCatalogo = mCatalogo;
            InitializeComponent();
            
        }

        private void frmAgregarCuenta_Load(object sender, EventArgs e)
        {
            cmbTipoCuenta.SelectedIndex = 0;
            cmbNombreCliente.SelectedIndex = 0;
            agregarTiposCuentas();
            tlpCuentas.SetToolTip(txtNumCuenta,
                "El número de cuenta es un número entero de 7 digitos que utilizamos para identificar su cuenta de forma unica y confidencial.");
            tlpCuentas.SetToolTip(txtMontoMin,"El monto de apertura debe de ser mayor o igual al monto minimo del tipo de cuenta que seleccione.\n" +
                "En algunos casos no se necesita de ningún monto minimo para aperturar la cuenta.");
        }

        private void agregarTiposCuentas()
        {
            string[] nombresCuentas = manejaCatalogo.obtieneNombres();

            foreach (string item in nombresCuentas)
            {
                if (item!=null) cmbTipoCuenta.Items.Add(item);
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

            if (!Rutinas.ValidaNumCuenta(claveCuenta))
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
                flag = false;
            }

            if(cmbNombreCliente.SelectedIndex==0)
            {
                MessageBox.Show("Nombre del cliente no seleccionado.", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }

            /*if (Rutinas.ValidaBlancos(monto))
            {
                MessageBox.Show("No se ha capturado el monto de la cuenta a aperturar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }*/

            return flag;
 
        }

        private void txtNumCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string numCuenta = txtNumCuenta.Text;

            if (!(char.IsNumber)(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorP.SetError(txtNumCuenta,"Este campo solo acepta caracteres numericos.");
            }
            else
            {
                if ((numCuenta+e.KeyChar.ToString()).Length>7 && e.KeyChar!= (char)Keys.Back)
                {
                    e.Handled = true;
                    errorP.SetError(txtNumCuenta, "La longitud del número es de unicamente 7 digitos.");
                }
                else
                    errorP.SetError(txtNumCuenta, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtMontoApertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            string monto = txtMontoApertura.Text;

            if (!Rutinas.ValidaDecimal(monto + e.KeyChar.ToString()) && e.KeyChar.ToString()!="." && e.KeyChar!=(char)Keys.Back)
            {
                e.Handled = true;
                errorP.SetError(txtMontoApertura,
               "El monto de apertura unicamente acepta valores enteros y decimales (hasta 2 digitos despues del punto).");
            }
            else
              errorP.SetError(txtMontoApertura,"");
        }

        private void ValidaNumCuenta(object sender, EventArgs e)
        {
            string numCuenta = txtNumCuenta.Text;

            if(Rutinas.ValidaBlancos(numCuenta))
                errorP.SetError(txtNumCuenta, "Este campo es obligatorio.");

            if (numCuenta.Length > 8)
                errorP.SetError(txtNumCuenta, "La longitud del número debe de ser de 7 digitos.");

            if (!txtNumCuenta.Focused && Rutinas.ValidaNumCuenta(numCuenta))
                errorP.SetError(txtNumCuenta, "");
        }

        private void ValidaMontoApertura(object sender, EventArgs e)
        {
            string monto = txtMontoApertura.Text;

            if (Rutinas.ValidaBlancos(monto))
                errorP.SetError(txtMontoApertura, "Este campo es obligatorio.");

            if(!txtMontoApertura.Focused && Rutinas.ValidaDecimal(monto)) 
                errorP.SetError(txtMontoApertura, "");
        }

        private void ValidaTipoCuenta(object sender, EventArgs e)
        {
            if (cmbTipoCuenta.SelectedIndex == 0)
                errorP.SetError(cmbTipoCuenta, "Seleccione un tipo de cuenta valido.");
            else
            {
                errorP.SetError(cmbTipoCuenta, "");
            }
        }

        private void limpiar()
        {
            txtMontoApertura.Text = "";
            txtNumCuenta.Text = "";
            cmbTipoCuenta.SelectedIndex = 0;
            errorP.Clear();
        }

        private bool VentanaVacia()
        {
            bool flag = false;

            string numCuenta = txtNumCuenta.Text;
            string monto = txtMontoApertura.Text;
            int datoTipo = cmbTipoCuenta.SelectedIndex;

            if (Rutinas.ValidaBlancos(numCuenta + monto) && datoTipo == 0)
                flag = true;

            return flag;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        public void Cerrar()
        {
            if (!VentanaVacia())
            {
                DialogResult res = MessageBox.Show("¿Seguro que desea salir?, hay cambios sin guardar y podría perderlos permanentemente.",
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void cmbTipoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoCuenta.SelectedIndex==0)
            {
                lblDatosTipo.Visible = false;
                lblDescripción.Visible = false;
                lblMontoMin.Visible = false;
                rchDesc.Visible = false;
                txtMontoMin.Visible = false;
            }
            else
            {
                TipoCuenta temp = manejaCatalogo.consulta(cmbTipoCuenta.Text);

                lblDatosTipo.Visible = true;
                lblDescripción.Visible = true;
                lblMontoMin.Visible = true;
                rchDesc.Visible = true;
                txtMontoMin.Visible = true;

                rchDesc.Text = temp.pDescripcion;
                txtMontoMin.Text = String.Format("{0:c}", temp.pMontoMinimo);
            }

        }
    }
}
