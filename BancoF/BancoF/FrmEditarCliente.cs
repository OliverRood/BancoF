using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RutinasDLL;

namespace BancoF
{
    public partial class FrmEditarCliente : Form
    {
        private ManejaCliente manejaCli;
        private int claveCliente;
        public FrmEditarCliente(ManejaCliente manejaCl)
        {
            InitializeComponent();
            this.manejaCli = manejaCl;
        }

        private void tsGuardarCliente_Click(object sender, EventArgs e)
        {

        }

        private void tsSalirVentana_Click(object sender, EventArgs e)
        {

        }

        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            Cliente[] temp2 = manejaCli.ObtenerClientes();

            foreach (Cliente item in temp2)
                cmbNombreCliente.Items.Add(item.pNombre);

            cmbNombreCliente.SelectedIndex = 0;
        }

        private void tsGuardarEdicion_Click(object sender, EventArgs e)
        {
            DialogResult res= MessageBox.Show("¿Desea guardar los datos del cliente?","Guardar",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(res==DialogResult.Yes)
            {
                string domicilio = txtDomicilio.Text;
                string tel = txtTelefono.Text;

                if (ValidaDatos())
                {
                    string menD = manejaCli.ActualizaDireccíon(domicilio,claveCliente);
                    string menT = manejaCli.ActualizaTelefono(tel, claveCliente);
                    MessageBox.Show(menD, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(menT, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
        }

        private bool ValidaDatos()
        {
            bool flag = true;
            string domicilio = txtDomicilio.Text;
            string tel = txtTelefono.Text;
            int index = cmbNombreCliente.SelectedIndex;

            if (index == 0)
            {
                MessageBox.Show("Nombre del cliente no seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Rutinas.ValidaBlancos(domicilio))
            {
                MessageBox.Show("Nombre del domicilio no capturado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                flag = false;
            }

            if (!Rutinas.ValidaTelefono(tel))
            {
                MessageBox.Show("Número de télefono con formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = false;
            }

            if (!Rutinas.ValidaDomicilio(domicilio))
            {
                DialogResult res = MessageBox.Show("El domicilio ingresado probablemente contenga un formato incorrecto.\n" +
                   "¿Desea guardarlo de todas formas?", "Formato de domicilio dudoso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (res == DialogResult.No)
                    flag = false;
            }

            return flag;

        }

        private void ValidaTelefono(object sender, EventArgs e)
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

        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbNombreCliente.SelectedIndex;
            if (index != 0)
            {
                txtDomicilio.Enabled = true;
                txtTelefono.Enabled = true;
                txtTelefono.ReadOnly = false;
                txtDomicilio.ReadOnly = false;

                claveCliente = manejaCli.KeyCliente(cmbNombreCliente.Text);
                Cliente temp = manejaCli.ObtenerCliente(claveCliente);

                txtClaveCliente.Text = claveCliente.ToString();
                txtCiudad.Text = temp.pCiudad;
                txtDomicilio.Text = temp.pDomicilio;
                txtTelefono.Text = temp.pTelefono;
            }
            else
            {
                txtDomicilio.Enabled = false;
                txtTelefono.Enabled = false;
                txtTelefono.ReadOnly = true;
                txtDomicilio.ReadOnly = true;
                claveCliente = -1;
                Limpiar();
            }

        }

        public void Limpiar()
        {
            txtClaveCliente.Text = "";
            txtCiudad.Text = "";
            txtDomicilio.Text = "";
            txtTelefono.Text = "";
            cmbNombreCliente.SelectedIndex = 0;
            errorP.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            DialogResult res = MessageBox.Show("¿Está seguro que desea salir de la edición del empleado?, podría perder datos ingresados.",
                "Aviso.",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (res == DialogResult.Yes)
                this.Close();
        }
    }
}
