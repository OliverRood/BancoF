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
    public partial class FrmMovimiento : Form
    {

        ManejaMovimiento manejaMovimiento;
        ManejaCuentas manejaCuentas;
        ManejaCliente manejaCliente;
        ManejaCatalogoCuenta manejaCatalogoCuenta;
        string nombre;

        public FrmMovimiento(ManejaMovimiento manejaMovimiento, ManejaCuentas manejaCuentas, ManejaCliente manejaCliente, ManejaCatalogoCuenta manejaCatalogoCuenta, string nombre)
        {
            this.manejaMovimiento = manejaMovimiento;
            this.manejaCuentas = manejaCuentas;
            this.manejaCliente = manejaCliente;
            this.manejaCatalogoCuenta = manejaCatalogoCuenta;
            this.nombre = nombre;
            InitializeComponent();
        }

        private void FrmMovimiento_Load(object sender, EventArgs e)
        {
            rdRetiro.Enabled = false;
            txtNombre.ReadOnly = false;
            txtNombre.Clear();
            toolTipM.SetToolTip(txtNombre, "Ingresa el nombre de quien realiza el deposito, solo se admiten letras");
            if (!string.IsNullOrEmpty(nombre))
            {
                txtNombre.ReadOnly = true;
                txtNombre.Text = nombre;
                rdRetiro.Enabled = true;
                toolTipM.SetToolTip(txtNombre, "Usuario que realiza el movimiento");
            }
            DateTime date = DateTime.Now;
            lblDateTimeNow.Text = date.ToString();
            toolTipM.SetToolTip(txtClave, "Ingresa la clave de la cuenta para el movimiento, solo se admiten digitos");
            toolTipM.SetToolTip(txtMonto, "Indica el monto del movimiento, solo se admiten digitos");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarAux()
        {
            txtClave.Clear();
            txtMonto.Clear();
            if (string.IsNullOrEmpty(nombre)) txtNombre.Clear();
            epMovimiento.Clear();
        }

        public bool Valida(string claveCuenta, string monto, string nombre)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(claveCuenta))
            {
                DialogResult error = MessageBox.Show("Clave cuenta no ingresada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (string.IsNullOrEmpty(monto))
            {
                DialogResult error = MessageBox.Show("Monto no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (string.IsNullOrEmpty(nombre))
            {
                DialogResult error = MessageBox.Show("Nombre no ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (ValidaInt(claveCuenta) > 0){}
            else
            {
                DialogResult error = MessageBox.Show("Caracter invalido con clave cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (ValidaDouble(monto) > 0){}
            else
            {
                DialogResult error = MessageBox.Show("Caracter invalido en monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (!ValidaNombre(nombre))
            {
                DialogResult error = MessageBox.Show("Caracteres invalidos en nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }

        public bool ValidaDeposito()
        {
            bool flag = true;
            string claveCuenta = txtClave.Text;
            string monto = txtMonto.Text;
            string nombre = txtNombre.Text;
            if (!Valida(claveCuenta, monto, nombre))
            {
                flag = false;
            }
            int claveC = Convert.ToInt32(claveCuenta);
            double montoI = Convert.ToDouble(monto);
            Cuenta temp = manejaCuentas.BuscarCuenta(claveC);
            if (temp==null)
            {
                DialogResult error = MessageBox.Show("La cuenta ingresada no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            if (montoI<0)
            {
                DialogResult error = MessageBox.Show("El monto ingresado es menor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }

        public bool ValidaRetiro()
        {
            bool flag = true;
            string claveCuenta = txtClave.Text;
            string monto = txtMonto.Text;
            string nombre = txtNombre.Text;
            if (!Valida(claveCuenta, monto, nombre))
            {
                flag = false;
            }
            int claveC = Convert.ToInt32(claveCuenta);
            double montoI = Convert.ToDouble(monto);
            Cuenta temp = manejaCuentas.BuscarCuenta(claveC);
            if (temp == null)
            {
                DialogResult error = MessageBox.Show("La cuenta ingresada no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else if (manejaCliente.KeyCliente(nombre) != temp.pClaveCliente)
            {
                DialogResult error = MessageBox.Show("La cuenta ingresada no pertenece al cliente actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else if (temp.pSaldo.Equals(manejaCatalogoCuenta.consulta(temp.pNombre).pMontoMinimo))
            {
                DialogResult error = MessageBox.Show("El saldo de la cuenta es igual al monto minimo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            else if ((temp.pSaldo - montoI) < (manejaCatalogoCuenta.consulta(temp.pNombre).pMontoMinimo))
            {
                DialogResult error = MessageBox.Show("El saldo actual menos la cantidad a retirar es inferior al saldo minimo requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = false;
            }
            return flag;
        }

        public bool ValidaNombre(string nombre)
        {
            bool resultado = Regex.IsMatch(nombre, @"^[a-zA-Z]+$");
            return resultado;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // KEY PRESS
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                epMovimiento.SetError(txtClave, "Solo se permiten numeros");
                e.Handled = true;
            }
            else
            {
                epMovimiento.SetError(txtClave, "");
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                epMovimiento.SetError(txtMonto, "SOLO SE PERMITEN NUMEROS");
                e.Handled = true;
            }
            else
            {
                epMovimiento.SetError(txtMonto, "");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                epMovimiento.SetError(txtNombre, "SOLO SE PERMITE TEXTO");
                e.Handled = true;
            }
            else
            {
                epMovimiento.SetError(txtNombre, "");
            }
        }

        // VALIDATED
        private void txtClave_Validated(object sender, EventArgs e)
        {
            string texto = txtClave.Text;
            if (ValidaInt(texto) > 0)
            {
                epMovimiento.SetError(txtClave, "");
            }
            else
            {
                epMovimiento.SetError(txtClave, "SOLO SE PERMITEN NUMEROS");
                txtClave.Focus();
            }
        }

        private void txtMonto_Validated(object sender, EventArgs e)
        {
            string texto = txtMonto.Text;
            if (ValidaDouble(texto) > 0)
            {
                epMovimiento.SetError(txtMonto, "");
            }
            else
            {
                epMovimiento.SetError(txtMonto, "SOLO SE PERMITEN NUMEROS");
                txtMonto.Focus();
            }
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            string datos = txtNombre.Text;
            if (datos.Length > 0)
            {
                epMovimiento.SetError(txtNombre, "");
            }
            else
            {
                epMovimiento.SetError(txtNombre, "Nombre no capturado");
            }
            
            if (ValidaNombre(datos))
            {
                epMovimiento.SetError(txtNombre, "");
            }
            else
            {
                epMovimiento.SetError(txtNombre, "Nombre con caracteres invalidos");
                txtNombre.Focus();
            }
        }

        public int ValidaInt(string texto)
        {
            int aux = 0;
            try
            {
                aux = Convert.ToInt32(texto);
            }
            catch (FormatException e)
            {
            }
            return aux;
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
                txtClave.Clear();
                txtMonto.Clear();
                if (string.IsNullOrEmpty(nombre)) txtNombre.Clear();
                epMovimiento.Clear();
            }
        }

        private void tsCerrarRealizarMovimiento_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir de TecBank?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (salir == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void realizarMovimientoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult guardar = MessageBox.Show("Desea realizar movimiento?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (guardar == DialogResult.Yes)
            {
                if (rdDeposito.Checked)
                {
                    if (ValidaDeposito())
                    {
                        string fecha = lblDateTimeNow.Text;
                        int claveCuenta = Convert.ToInt32(txtClave.Text);
                        double monto = Convert.ToDouble(txtMonto.Text);
                        string nombre = txtNombre.Text;
                        if (manejaMovimiento.Deposito(fecha, monto, claveCuenta, nombre))
                        {
                            MessageBox.Show("Deposito realizado con exito", "Realizar movimiento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarAux();
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar deposito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    if (ValidaRetiro())
                    {
                        string fecha = lblDateTimeNow.Text;
                        int claveCuenta = Convert.ToInt32(txtClave.Text);
                        double monto = Convert.ToDouble(txtMonto.Text);
                        string nombre = txtNombre.Text;
                        if (manejaMovimiento.Retiro(fecha, monto, claveCuenta, nombre))
                        {
                            MessageBox.Show("Retiro realizado con exito", "Realizar movimiento", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            LimpiarAux();
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar retiro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            lblSaldo.Text = "";
            string cveCuenta = txtClave.Text;
            int claveCuenta = ValidaInt(cveCuenta);
            Cuenta temp = manejaCuentas.BuscarCuenta(claveCuenta);
            if (temp != null && !(string.IsNullOrEmpty(nombre))) lblSaldo.Text = "Saldo: $"+temp.pSaldo+" MXN";
        }
    }
}
