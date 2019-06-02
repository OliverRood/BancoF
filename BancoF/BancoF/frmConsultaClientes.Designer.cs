namespace BancoF
{
    partial class FrmConsultaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaClientes));
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblClienteConsulta = new System.Windows.Forms.Label();
            this.lblClaveCliente = new System.Windows.Forms.Label();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbNombreCliente = new System.Windows.Forms.ComboBox();
            this.dgvCuentasCliente = new System.Windows.Forms.DataGridView();
            this.txtClaveCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSaldoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCuentasCliente = new System.Windows.Forms.Label();
            this.lblDatosCli = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelDiv = new System.Windows.Forms.Panel();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblClientes.Location = new System.Drawing.Point(71, 58);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(122, 32);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Clientes";
            // 
            // lblClienteConsulta
            // 
            this.lblClienteConsulta.AutoSize = true;
            this.lblClienteConsulta.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteConsulta.Location = new System.Drawing.Point(53, 121);
            this.lblClienteConsulta.Name = "lblClienteConsulta";
            this.lblClienteConsulta.Size = new System.Drawing.Size(224, 18);
            this.lblClienteConsulta.TabIndex = 2;
            this.lblClienteConsulta.Text = "Nombre del cliente a consultar";
            // 
            // lblClaveCliente
            // 
            this.lblClaveCliente.AutoSize = true;
            this.lblClaveCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCliente.Location = new System.Drawing.Point(53, 236);
            this.lblClaveCliente.Name = "lblClaveCliente";
            this.lblClaveCliente.Size = new System.Drawing.Size(45, 17);
            this.lblClaveCliente.TabIndex = 4;
            this.lblClaveCliente.Text = "Clave";
            this.lblClaveCliente.Click += new System.EventHandler(this.lblClaveCliente_Click);
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtClaveCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveCliente.Enabled = false;
            this.txtClaveCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCliente.Location = new System.Drawing.Point(56, 262);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.ReadOnly = true;
            this.txtClaveCliente.Size = new System.Drawing.Size(239, 24);
            this.txtClaveCliente.TabIndex = 2;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(53, 297);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(68, 17);
            this.lblDomicilio.TabIndex = 6;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(56, 324);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(239, 24);
            this.txtDomicilio.TabIndex = 3;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(53, 362);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(54, 17);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(56, 391);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(239, 24);
            this.txtCiudad.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(53, 431);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(135, 17);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Número de télefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(56, 464);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(239, 24);
            this.txtTelefono.TabIndex = 11;
            // 
            // cmbNombreCliente
            // 
            this.cmbNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreCliente.FormattingEnabled = true;
            this.cmbNombreCliente.Items.AddRange(new object[] {
            "SELECCIONE AL CLIENTE"});
            this.cmbNombreCliente.Location = new System.Drawing.Point(56, 152);
            this.cmbNombreCliente.Name = "cmbNombreCliente";
            this.cmbNombreCliente.Size = new System.Drawing.Size(239, 25);
            this.cmbNombreCliente.TabIndex = 1;
            this.cmbNombreCliente.SelectedIndexChanged += new System.EventHandler(this.cmbNombreCliente_SelectedIndexChanged);
            // 
            // dgvCuentasCliente
            // 
            this.dgvCuentasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtClaveCuenta,
            this.txtTipoCuenta,
            this.txtSaldoActual,
            this.Editar});
            this.dgvCuentasCliente.Location = new System.Drawing.Point(375, 140);
            this.dgvCuentasCliente.Name = "dgvCuentasCliente";
            this.dgvCuentasCliente.ReadOnly = true;
            this.dgvCuentasCliente.Size = new System.Drawing.Size(574, 381);
            this.dgvCuentasCliente.TabIndex = 15;
            this.dgvCuentasCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuentasCliente_CellContentClick);
            // 
            // txtClaveCuenta
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCuenta.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtClaveCuenta.HeaderText = "Clave";
            this.txtClaveCuenta.Name = "txtClaveCuenta";
            this.txtClaveCuenta.ReadOnly = true;
            this.txtClaveCuenta.Width = 130;
            // 
            // txtTipoCuenta
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoCuenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtTipoCuenta.HeaderText = "Tipo de cuenta";
            this.txtTipoCuenta.Name = "txtTipoCuenta";
            this.txtTipoCuenta.ReadOnly = true;
            this.txtTipoCuenta.Width = 160;
            // 
            // txtSaldoActual
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoActual.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtSaldoActual.HeaderText = "Saldo Actual ";
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.ReadOnly = true;
            this.txtSaldoActual.Width = 140;
            // 
            // Editar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Editar.HeaderText = "Edición";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // lblCuentasCliente
            // 
            this.lblCuentasCliente.AutoSize = true;
            this.lblCuentasCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentasCliente.Location = new System.Drawing.Point(566, 97);
            this.lblCuentasCliente.Name = "lblCuentasCliente";
            this.lblCuentasCliente.Size = new System.Drawing.Size(157, 19);
            this.lblCuentasCliente.TabIndex = 16;
            this.lblCuentasCliente.Text = "Cuentas del Cliente";
            // 
            // lblDatosCli
            // 
            this.lblDatosCli.AutoSize = true;
            this.lblDatosCli.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCli.Location = new System.Drawing.Point(52, 200);
            this.lblDatosCli.Name = "lblDatosCli";
            this.lblDatosCli.Size = new System.Drawing.Size(131, 18);
            this.lblDatosCli.TabIndex = 17;
            this.lblDatosCli.Text = "Datos del cliente:";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(975, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 29);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelDiv
            // 
            this.panelDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.panelDiv.Location = new System.Drawing.Point(-1, 543);
            this.panelDiv.Name = "panelDiv";
            this.panelDiv.Size = new System.Drawing.Size(984, 57);
            this.panelDiv.TabIndex = 30;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNombreCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(55, 153);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(239, 24);
            this.txtNombreCliente.TabIndex = 32;
            this.txtNombreCliente.Visible = false;
            // 
            // FrmConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblDatosCli);
            this.Controls.Add(this.lblCuentasCliente);
            this.Controls.Add(this.dgvCuentasCliente);
            this.Controls.Add(this.cmbNombreCliente);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtClaveCliente);
            this.Controls.Add(this.lblClaveCliente);
            this.Controls.Add(this.lblClienteConsulta);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.panelDiv);
            this.Controls.Add(this.txtNombreCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultaClientes";
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblClienteConsulta;
        private System.Windows.Forms.Label lblClaveCliente;
        private System.Windows.Forms.TextBox txtClaveCliente;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbNombreCliente;
        private System.Windows.Forms.DataGridView dgvCuentasCliente;
        private System.Windows.Forms.Label lblCuentasCliente;
        private System.Windows.Forms.Label lblDatosCli;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelDiv;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtClaveCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSaldoActual;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}