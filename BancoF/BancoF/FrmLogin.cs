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
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            frnVentanaPrincipal frnVentanaPrincipal = new frnVentanaPrincipal(true, Nombre);
            txtNombre.Clear();
            frnVentanaPrincipal.ShowDialog();
        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            frnVentanaPrincipal frnVentanaPrincipal = new frnVentanaPrincipal(false, "Administrador");
            txtNombre.Clear();
            frnVentanaPrincipal.ShowDialog();
        }
    }
}
