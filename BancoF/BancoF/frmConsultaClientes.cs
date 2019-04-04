﻿using System;
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
    public partial class frmConsultaClientes : Form
    {
        private ManejaCliente manejaCli;
        private ManejaCuentas manejaCuentas;
        string nombreCliente;
        private bool flagCliente;

        public frmConsultaClientes(bool cliente,string nomCliente,ManejaCliente mClientes, ManejaCuentas mCuentas)
        {
            InitializeComponent();
            flagCliente = cliente;
            this.nombreCliente = nomCliente;
            this.manejaCli = mClientes;
            this.manejaCuentas = mCuentas;
        }

        private void lblClaveCliente_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaClientes_Load(object sender, EventArgs e)
        {
            if (flagCliente)
            {
                lblClienteConsulta.Visible = false;
                cmbNombreCliente.Visible = false;
            }
            else
            {
                Cliente[] temp = manejaCli.ObtenerClientes();

                foreach (Cliente item in temp)
                    cmbNombreCliente.Items.Add(item.pNombre);

                cmbNombreCliente.SelectedIndex = 0;
            }
        }

        public void AgregarDatosCliente()
        {
            string nomCliente = flagCliente? nombreCliente:cmbNombreCliente.Text;
            int claveCliente = manejaCli.KeyCliente(nomCliente);
            Cliente tempCli = manejaCli.ObtenerCliente(claveCliente);

            txtClaveCliente.Text = claveCliente.ToString();
            txtDomicilio.Text = tempCli.pDomicilio;
            txtCiudad.Text = tempCli.pCiudad;
            txtTelefono.Text = tempCli.pTelefono;

        }

        public void AgregarCuentas()
        {
            string nomCliente = cmbNombreCliente.Text;
            int claveCliente = manejaCli.KeyCliente(nomCliente);

            KeyValuePair<int, Cuenta>[] temp = manejaCuentas.ObtenerPorCliente(claveCliente);

            foreach (KeyValuePair<int, Cuenta> item in temp)
            {
                string saldo = String.Format("{0:c}",item.Value.pSaldo);
                dgvCuentasCliente.Rows.Add(item.Key, item.Value.pNombre,saldo);
            }

        }

        private void cmbNombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmbNombreCliente.SelectedIndex;

            if (index != 0)
            {
                AgregarDatosCliente();
                AgregarCuentas();
            }
            else
            {
                Limpiar();
            }
        }

        public void Limpiar()
        {
            txtClaveCliente.Text = "";
            txtDomicilio.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            dgvCuentasCliente.Rows.Clear();
        }
    }
}
