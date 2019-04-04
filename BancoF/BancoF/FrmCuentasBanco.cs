using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoF
{
    public partial class FrmCuentasBanco : Form
    {
        ManejaCatalogoCuenta manejaCatalogoCuenta;

        public FrmCuentasBanco(ManejaCatalogoCuenta manejaCatalogoCuenta)
        {
            this.manejaCatalogoCuenta = manejaCatalogoCuenta;
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCuentasBanco_Load(object sender, EventArgs e)
        {

        }

        // KEYPRESS

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar != (char) Keys.Back)
            {
                epCuentasBanco.SetError(txtNombre, "SOLO SE PERMITE TEXTO");
                e.Handled = true;
            }
            else
            {
                epCuentasBanco.SetError(txtNombre, "");
            }
        }

        private void txtMontoMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                epCuentasBanco.SetError(txtMontoMinimo, "SOLO SE PERMITEN NUMEROS");
                e.Handled = true;
            }
            else
            {
                epCuentasBanco.SetError(txtMontoMinimo, "");
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                epCuentasBanco.SetError(txtDescripcion, "SOLO SE PERMITE TEXTO");
                e.Handled = true;
            }
            else
            {
                epCuentasBanco.SetError(txtDescripcion, "");
            }
        }

        // VALIDATED

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string datos = txtNombre.Text;
            if (datos.Length>0)
            {
                epCuentasBanco.SetError(txtNombre, "");
            }
            else
            {
                epCuentasBanco.SetError(txtNombre, "Nombre no capturado");
            }

            if (!ValidaTexto(datos))
            {
                epCuentasBanco.SetError(txtNombre, "Nombre con caracteres invalidos");
                txtNombre.Focus();
            }
            else
            {
                epCuentasBanco.SetError(txtNombre, "");
            }

        }

        private void txtMontoMinimo_Validated(object sender, EventArgs e)
        {
            string monto = txtMontoMinimo.Text;
            if (ValidaDouble(monto) > 0)
            {
                epCuentasBanco.SetError(txtMontoMinimo, "");
            }
            else
            {
                epCuentasBanco.SetError(txtMontoMinimo, "Solo se permiten numeros");
            }
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            string datos = txtDescripcion.Text;
            if (datos.Length > 0)
            {
                epCuentasBanco.SetError(txtDescripcion, "");
            }
            else
            {
                epCuentasBanco.SetError(txtDescripcion, "Descripcion no capturada");
                txtDescripcion.Focus();
            }

            if (!ValidaTexto(datos))
            {
                epCuentasBanco.SetError(txtDescripcion, "Descripcion con caracteres invalidos");
                txtNombre.Focus();
            }
            else
            {
                epCuentasBanco.SetError(txtDescripcion, "");
            }
        }

        public bool ValidaTexto(string nombre)
        {
            bool resultado = Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
            return resultado;
        }

        public double ValidaDouble(string texto)
        {
            double aux = 0;
            try
            {
                aux = Convert.ToDouble(texto);
            }
            catch (FormatException e)
            {
            }
            return aux;
        }

        // BOTONES

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult limpiar = MessageBox.Show("Desea limpiar?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (limpiar == DialogResult.Yes)
            {
                txtNombre.Clear();
                txtMontoMinimo.Clear();
                txtDescripcion.Clear();
                epCuentasBanco.Clear();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult guardar = MessageBox.Show("Desea guardar?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (guardar == DialogResult.Yes)
            {
                if (Valida())
                {
                    string nombre = txtNombre.Text;
                    double montoMinimo = Convert.ToDouble(txtMontoMinimo.Text);
                    string descripcion = txtDescripcion.Text;
                    manejaCatalogoCuenta.agrega(nombre, montoMinimo, descripcion);
                    MessageBox.Show("","", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNombre.Clear();
                    txtMontoMinimo.Clear();
                    txtDescripcion.Clear();
                }
            }
        }

        // VALIDA

        public bool Valida()
        {
            bool flag = true;
            string nombre = txtNombre.Text;
            string montoMinimo = txtMontoMinimo.Text;
            string descripcion = txtDescripcion.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                DialogResult error = MessageBox.Show("Nombre no capturado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (string.IsNullOrEmpty(montoMinimo))
            {
                DialogResult error = MessageBox.Show("Monto minimo no capturado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (string.IsNullOrEmpty(descripcion))
            {
                DialogResult error = MessageBox.Show("Descripcion no capturada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (!ValidaTexto(nombre))
            {
                DialogResult error = MessageBox.Show("Nombre con caracteres invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (ValidaDouble(montoMinimo) > 0) { }
            else
            {
                DialogResult error = MessageBox.Show("Monto minimo con caracteres invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (!ValidaTexto(descripcion))
            {
                DialogResult error = MessageBox.Show("Nombre con caracteres invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (manejaCatalogoCuenta.consulta(nombre)!=null)
            {
                DialogResult error = MessageBox.Show("Cuenta ya existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }
        
    }
}
