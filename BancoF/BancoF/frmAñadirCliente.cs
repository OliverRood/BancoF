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
    public partial class frmAgregarCliente : Form
    {
        private ManejaCliente manejaCli;
        public frmAgregarCliente(ManejaCliente maneja)
        {
            this.manejaCli = maneja;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            cmbCiudad.SelectedIndex = 0;
            string datosTel = String.Format("Solo se aceptan números celulares. {0} {1} {2} {3}",
                "Algunos formatos aceptables para el número de télefono son:\n","+52(***)-***-**-**\n","(***) *** *** ** **\n","**********");
            tlpClientes.SetToolTip(txtTelefono,datosTel);
            tlpClientes.SetToolTip(txtDomicilio,"Es importante ubicar correctamente la dirección del cliente.");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void tsGuardarCliente_Click(object sender, EventArgs e)
        {
            DialogResult res= MessageBox.Show("¿Desea guardar los datos del cliente?","Guardar",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(res==DialogResult.Yes)
            {
                string nombreCliente = txtNombreCliente.Text;
                string domicilio = txtDomicilio.Text;
                string ciudad = cmbCiudad.Text;
                string tel = txtTelefono.Text;

                if (ValidaDatos())
                {
                    manejaCli.Agrega(nombreCliente, domicilio, ciudad, tel);
                    MessageBox.Show("Cliente agregado exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
        }

        public bool ValidaDatos()
        {
            bool flag = true;
            string nomCliente = txtNombreCliente.Text;
            string domicilio = txtDomicilio.Text;
            string ciudad = cmbCiudad.Text;
            string tel = txtTelefono.Text;

            if (Rutinas.ValidaBlancos(nomCliente))
            {
                MessageBox.Show("Nombre del cliente no capturado.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                flag = false;
            }

            if (Rutinas.ValidaBlancos(domicilio))
            {
                MessageBox.Show("Nombre del domicilio no capturado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            if (cmbCiudad.SelectedIndex == 0)
            {
                MessageBox.Show("Ciudad no seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            if (Rutinas.ValidaBlancos(tel))
            {
                MessageBox.Show("Número de télefono no capturado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            if (!Rutinas.ValidaTelefono(tel))
            {
                MessageBox.Show("Número de télefono con formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = false;
            }

            if (!Rutinas.ValidaDomicilio(domicilio))
            {
                DialogResult res= MessageBox.Show("El domicilio ingresado probablemente contenga un formato incorrecto.\n" +
                   "¿Desea guardarlo de todas formas?","Formato de domicilio dudoso",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.No)
                    flag = false;
            }

            if (Rutinas.ValidaBlancos(domicilio))
            {
                MessageBox.Show("Es importante conocer la ubicación del cliente. Favor de completar esta información.","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            if (manejaCli.KeyCliente(nomCliente) != -1)
            {
                MessageBox.Show("Ya existe un cliente con ese nombre. Favor de ingresar uno distinto.", "Autentificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = false;
            }

            return flag;
        }

        private void tsSalirVentana_Click(object sender, EventArgs e)
        {
            if (!VentanaVacia())
            {
                DialogResult res = MessageBox.Show("¿Seguro que desea salir?, hay cambios sin guardar y podría perderlos permanentemente.",
                    "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res==DialogResult.Yes)
                    this.Close();
            }
            else
            {
                this.Close();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
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

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nombreCli = txtNombreCliente.Text;
            if(!Rutinas.ValidaCaracteres(nombreCli +e.KeyChar.ToString()) && e.KeyChar !=(char)Keys.Back)
            {
                errorP.SetError(txtNombreCliente,"El nombre del cliente solo acepta caracteres alfabeticos.");
                e.Handled = true;
            }
            else
                errorP.SetError(txtNombreCliente, "");
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            txtNombreCliente.Text = "";
            txtDomicilio.Text = "";
            cmbCiudad.SelectedIndex = 0;
            txtTelefono.Text = "";
            errorP.Clear();
        }

        private bool VentanaVacia()
        {
            bool flag = false;

            string nomCliente = txtNombreCliente.Text;
            string dom = txtDomicilio.Text;
            string tel = txtTelefono.Text;
            int datoCi = cmbCiudad.SelectedIndex;

            if (Rutinas.ValidaBlancos(nomCliente + dom + tel) && datoCi == 0)
                flag = true;

            return flag;
        }

        private void cmbCiudad_Validated(object sender, EventArgs e)
        {
            if (cmbCiudad.SelectedIndex == 0)
            {
                errorP.SetError(cmbCiudad, "Es necesario que seleccione una ciudad.");
            }
            else
                errorP.SetError(cmbCiudad, "");
        }

        private void ValidaTélefono(object sender, EventArgs e)
        {
            string tel = txtTelefono.Text;

            if (!Rutinas.ValidaTelefono(tel))
            {
                errorP.SetError(txtTelefono, "Debe ingresar un formato de télefono valido");
            }
            else
            {
                errorP.SetError(txtTelefono, "");
            }
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
