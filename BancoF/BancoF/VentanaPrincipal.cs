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
    public partial class frnVentanaPrincipal : Form
    {

        private bool flagUsuario = true;
        private string nombre;
        private ManejaCliente manejaCli;
        private ManejaCuentas manejaCuentas;
        private ManejaCatalogoCuenta manejaCatalogo;
        private ManejaMovimiento manejaMovi;

        public frnVentanaPrincipal(bool FlagUsuario, string Nombre, ManejaCliente mCli, ManejaCuentas mCue, ManejaCatalogoCuenta mCat, ManejaMovimiento mMov)
        {
            this.manejaCli = mCli;
            this.manejaCuentas = mCue;
            this.manejaCatalogo = mCat;
            this.manejaMovi = mMov;

            InitializeComponent();
            this.flagUsuario = FlagUsuario;
            this.nombre = Nombre;
        }

        private void frnVentanaPrincipal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblFecha.Text = Convert.ToString(fecha);
            lblNombre.Text = "¡" + (nombre!=null ? nombre:"Bienvenido") + " !";
            if (flagUsuario)
            {
                tsMovimiento.Visible = true;
                tsCuenta.Visible = true;
                tsCliente.Visible = false;
                tsBanco.Visible = false;
                if (string.IsNullOrEmpty(nombre))
                {
                    tsCuenta.Enabled = false;
                    consultarToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                tsMovimiento.Visible = false;
                tsCuenta.Visible = false;
                tsCliente.Visible = true;
                tsBanco.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void realizarMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimiento frmMovimiento = new FrmMovimiento(manejaMovi, manejaCuentas, manejaCli, nombre);
            frmMovimiento.ShowDialog();
        }

        private void cerrarCesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsAltaCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente altaCliente = new frmAgregarCliente(manejaCli);
            altaCliente.ShowDialog();
        }

        private void tsCuenta_Click(object sender, EventArgs e)
        {

        }

    }
}
