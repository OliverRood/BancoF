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
    public partial class FrmConsultaCuentasBanco : Form
    {

        ManejaCatalogoCuenta manejaCatalogoCuenta;

        public FrmConsultaCuentasBanco(ManejaCatalogoCuenta manejaCatalogoCuenta)
        {
            this.manejaCatalogoCuenta = manejaCatalogoCuenta;
            InitializeComponent();
        }

        private void FrmConsultaCuentasBanco_Load(object sender, EventArgs e)
        {
            String[] nombres = new String[manejaCatalogoCuenta.Count()];
            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i]!=null)
                {
                    cmbNombre.Items.Add(nombres[i]);
                }
            }
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = Convert.ToString(cmbNombre.SelectedItem);
            TipoCuenta temp = manejaCatalogoCuenta.consulta(nombre);
            lblNombreSelected.Text = temp.pNombre;
            lblMontoMInimoSelected.Text = Convert.ToString(temp.pMontoMinimo);
            lblDescripcionSelected.Text = temp.pDescripcion;
        }
    }
}
