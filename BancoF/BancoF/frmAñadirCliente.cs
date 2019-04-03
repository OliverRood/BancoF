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
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void tsGuardarCliente_Click(object sender, EventArgs e)
        {
            string nombreCliente = txtNombreCliente.Text;
            string domicilio = txtDomicilio.Text;
            string ciudad = cmbCiudad.Text;
            string tel = txtTelefono.Text;

            manejaCli.Agrega(nombreCliente,domicilio,ciudad,tel);
        }

        private void tsSalirVentana_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
