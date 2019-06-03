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
    }
}
