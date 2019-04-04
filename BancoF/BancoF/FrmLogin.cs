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
    public partial class FrmLogin : Form
    {
        private ManejaCliente manejaCli;
        private ManejaCuentas manejaCuentas;
        private ManejaCatalogoCuenta manejaCatalogo;
        private ManejaMovimiento manejaMovi;

        public FrmLogin()
        {
            this.manejaCli = new ManejaCliente();
            this.manejaCuentas = new ManejaCuentas();
            this.manejaCatalogo = new ManejaCatalogoCuenta();
            this.manejaMovi = new ManejaMovimiento(manejaCuentas);

            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (manejaCli.KeyCliente(nombre) != -1)
            {
                frnVentanaPrincipal frnVentanaPrincipal = new frnVentanaPrincipal(true, nombre, manejaCli, manejaCuentas, manejaCatalogo, manejaMovi);
                txtNombre.Clear();
                frnVentanaPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existe registro de ningún cliente con este nombre, favor de ingresar algún otro",
                    "Nombre de cliente no encontrado.",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            frnVentanaPrincipal frnVentanaPrincipal = new frnVentanaPrincipal(false, "Administrador", manejaCli, manejaCuentas, manejaCatalogo, manejaMovi);
            txtNombre.Clear();

            frnVentanaPrincipal.ShowDialog();
            CargarClientes();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {
            Cliente[] temp = manejaCli.ObtenerClientes();

            foreach (Cliente item in temp)
            {
                if(!txtNombre.AutoCompleteCustomSource.Contains(item.pNombre))
                txtNombre.AutoCompleteCustomSource.Add(item.pNombre);
            }
                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            frnVentanaPrincipal frnVentanaPrincipal = new frnVentanaPrincipal(true, null, manejaCli, manejaCuentas, manejaCatalogo, manejaMovi);
            txtNombre.Clear();
            frnVentanaPrincipal.ShowDialog();
        }
    }
}
