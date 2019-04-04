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
        int ClaveCliente;

        public frmAgregarCuenta()
        {
            InitializeComponent();
        }

        private void btnConsultaCuenta_Click(object sender, EventArgs e)
        {

        }

        private void frmAgregarCuenta_Load(object sender, EventArgs e)
        {
            

            cmbTipoCuenta.SelectedIndex = 0;
        }
    }
}
