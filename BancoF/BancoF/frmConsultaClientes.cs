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
    public partial class frmConsultaClientes : Form
    {
        private ManejaCliente manejaCli;
        private ManejaCuentas manejaCuentas;
        string nombreCliente;
        private bool flagCliente;

        public frmConsultaClientes(bool cliente,string nomCliente,ManejaCliente mClientes, ManejaCuentas mCuentas)
        {
            InitializeComponent();
            flagCliente = cliente;
            this.nombreCliente = nomCliente;
            this.manejaCli = mClientes;
            this.manejaCuentas = mCuentas;
        }

        private void lblClaveCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            if (flagCliente)
            {
                lblClienteConsulta.Text = "Nombre del cliente:";
                cmbNombreCliente.Visible = false;
                txtNombreCliente.Visible = true;
                AgregarDatosCliente();
                AgregarCuentas();
            }
            else
            {
                Cliente[] temp = manejaCli.ObtenerClientes();

                foreach (Cliente item in temp)
                    cmbNombreCliente.Items.Add(item.pNombre);

                cmbNombreCliente.SelectedIndex = 0;
            }
        }

        public void AgregarDatosCliente()
        {
            string nomCliente = flagCliente? nombreCliente:cmbNombreCliente.Text;
            int claveCliente = manejaCli.KeyCliente(nomCliente);
            Cliente tempCli = manejaCli.ObtenerCliente(claveCliente);

            txtClaveCliente.Text = claveCliente.ToString();
            txtDomicilio.Text = tempCli.pDomicilio;
            txtCiudad.Text = tempCli.pCiudad;
            txtTelefono.Text = tempCli.pTelefono;
            txtNombreCliente.Text = nomCliente;

        }

        public void AgregarCuentas()
        {
            string nomCliente = flagCliente ? nombreCliente : cmbNombreCliente.Text;
            int claveCliente = manejaCli.KeyCliente(nomCliente);
            MessageBox.Show(claveCliente.ToString());

            List<Cuenta> temp = manejaCuentas.ObtenerPorCliente(claveCliente);
            MessageBox.Show("Entra?");
            dgvCuentasCliente.Rows.Clear();

            foreach (Cuenta item in temp)
            {
                string saldo = String.Format("{0:c}",item.pSaldo);
                dgvCuentasCliente.Rows.Add(item.Clave, item.pNombre,saldo);
            }

        }

        private void cmbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbNombreCliente.SelectedIndex;

            if (index != 0)
            {
                AgregarDatosCliente();
                AgregarCuentas();
            }
            else
            {
                Limpiar();
            }
        }

        public void Limpiar()
        {
            txtClaveCliente.Text = "";
            txtDomicilio.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            dgvCuentasCliente.Rows.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
