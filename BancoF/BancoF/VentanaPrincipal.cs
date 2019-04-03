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

        bool FlagUsuario = true;
        string Nombre = "";

        public frnVentanaPrincipal(bool FlagUsuario, string Nombre)
        {
            InitializeComponent();
            this.FlagUsuario = FlagUsuario;
            this.Nombre = Nombre;
        }

        private void frnVentanaPrincipal_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            lblFecha.Text = Convert.ToString(fecha);
            lblNombre.Text = Nombre + " !";
            if (FlagUsuario == true)
            {
                tsMovimiento.Visible = true;
                tsCuenta.Visible = true;
                tsCliente.Visible = false;
                tsBanco.Visible = false;
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
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void realizarMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimiento frmMovimiento = new FrmMovimiento();
            frmMovimiento.ShowDialog();
        }

        private void cerrarCesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
