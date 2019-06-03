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

        private char tipoUsuario =' ';
        private string nombre;
        private ManejaCliente manejaCli;
        private ManejaCuentas manejaCuentas;
        private ManejaCatalogoCuenta manejaCatalogo;
        private ManejaMovimiento manejaMovi;

        public frnVentanaPrincipal(char tipoU, string Nombre, ManejaCliente mCli, ManejaCuentas mCue, ManejaCatalogoCuenta mCat, ManejaMovimiento mMov)
        {
            this.manejaCli = mCli;
            this.manejaCuentas = mCue;
            this.manejaCatalogo = mCat;
            this.manejaMovi = mMov;
            InitializeComponent();
            this.tipoUsuario = tipoU;
            this.nombre = Nombre;
            menuStrip1.Renderer = new MyRenderer();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return ColorTranslator.FromHtml("#d9d9d9"); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return ColorTranslator.FromHtml("#d9d9d9"); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return ColorTranslator.FromHtml("#d9d9d9"); }
            }
        }

        private void frnVentanaPrincipal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblFecha.Text = Convert.ToString(fecha);
            lblNombre.Text = "¡" + (nombre != null ? nombre : "Bienvenido") + " !";
            switch (tipoUsuario)
            {

                case ('U'):
                    tsMovimiento.Visible = true;
                    tsCuenta.Visible = true;
                    tsAgregarCuenta.Visible = false;
                    tsCerrarCuenta.Visible = false;
                    tsCliente.Visible = false;
                    tsBanco.Visible = false;
                    if (string.IsNullOrEmpty(nombre))
                    {
                        tsCuenta.Enabled = false;
                        consultarToolStripMenuItem.Enabled = false;
                    }
                    break;

                case ('A'):
                    tsMovimiento.Visible = false;
                    tsCuenta.Visible = false;
                    tsCliente.Visible = true;
                    tsBanco.Visible = true;
                    tsReportes.Visible = false;
                    break;
                case ('E'):
                    tsCrearTipoCuenta.Visible = false;
                    tsMovimientosBanco.Visible = false;
                    tsMovimiento.Visible = false;
                    tsCliente.Visible =false;
                    tsConsultarCuenta.Visible = false;
                    break;

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
            FrmMovimiento frmMovimiento = new FrmMovimiento(manejaMovi, manejaCuentas, manejaCli, manejaCatalogo, nombre);
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

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaCuentasBanco frmConsultaCuentasBanco = new FrmConsultaCuentasBanco(manejaCatalogo);
            frmConsultaCuentasBanco.ShowDialog();
        }

        private void creaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCuentasBanco frmCuentasBanco = new FrmCuentasBanco(manejaCatalogo);
            frmCuentasBanco.ShowDialog();
        }

        private void tsAgregarCuenta_Click(object sender, EventArgs e)
        {
            frmAgregarCuenta añadirCuenta = new frmAgregarCuenta(manejaCuentas, manejaCatalogo,manejaCli);
            añadirCuenta.ShowDialog();
        }

        private void tsConsultaClientes_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes consultaCli = new FrmConsultaClientes('A', "", manejaCli, manejaCuentas);
            consultaCli.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes consultaCli = new FrmConsultaClientes('U',nombre, manejaCli, manejaCuentas);
            consultaCli.ShowDialog();
        }

        private void porCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMovimientosClientes frmConsultaMovimientosClientes = new FrmConsultaMovimientosClientes(manejaMovi, manejaCli, manejaCuentas, nombre, true);
            frmConsultaMovimientosClientes.ShowDialog();
        }

        private void todoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMovimientosClientes frmConsultaMovimientosClientes = new FrmConsultaMovimientosClientes(manejaMovi, manejaCli, manejaCuentas, nombre, false);
            frmConsultaMovimientosClientes.ShowDialog();
        }
        
        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaMovimientos frmConsultaMovimientos = new FrmConsultaMovimientos(manejaMovi);
            frmConsultaMovimientos.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        private void tsCerrarCuenta_Click(object sender, EventArgs e)
        {
            FrmConsultaClientes consultaCli = new FrmConsultaClientes('E', "", manejaCli, manejaCuentas);
            consultaCli.ShowDialog();
        }

        private void tsReportesMovimientos_Click(object sender, EventArgs e)
        {
            frmReportMovimientos frmReportMovimientos = new frmReportMovimientos();
            frmReportMovimientos.ShowDialog();
        }

        private void editarDatosDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarCliente editarCliente = new FrmEditarCliente(manejaCli);
            editarCliente.ShowDialog();
        }

        private void tsReportesCuentas_Click(object sender, EventArgs e)
        {
            FrmReportCuentasClientes reporteCuentas = new FrmReportCuentasClientes();
            reporteCuentas.ShowDialog();
        }
    }
}
