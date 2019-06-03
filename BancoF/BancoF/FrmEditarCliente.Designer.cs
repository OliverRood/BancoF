namespace BancoF
{
    partial class FrmEditarCliente
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
            this.lblClientes = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGuardarEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelDiv = new System.Windows.Forms.Panel();
            this.cmbNombreCliente = new System.Windows.Forms.ComboBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.lblDatosCli = new System.Windows.Forms.Label();
            this.txtClaveCliente = new System.Windows.Forms.TextBox();
            this.lblClaveCliente = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblClientes.Location = new System.Drawing.Point(96, 92);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(122, 32);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "Clientes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGuardarEdicion,
            this.tsSalir});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // tsGuardarEdicion
            // 
            this.tsGuardarEdicion.Name = "tsGuardarEdicion";
            this.tsGuardarEdicion.Size = new System.Drawing.Size(180, 22);
            this.tsGuardarEdicion.Text = "Guardar";
            // 
            // tsSalir
            // 
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(180, 22);
            this.tsSalir.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(977, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 29);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panelDiv
            // 
            this.panelDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.panelDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelDiv.Location = new System.Drawing.Point(0, 519);
            this.panelDiv.Name = "panelDiv";
            this.panelDiv.Size = new System.Drawing.Size(988, 64);
            this.panelDiv.TabIndex = 31;
            // 
            // cmbNombreCliente
            // 
            this.cmbNombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNombreCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreCliente.FormattingEnabled = true;
            this.cmbNombreCliente.Items.AddRange(new object[] {
            "SELECCIONE AL CLIENTE"});
            this.cmbNombreCliente.Location = new System.Drawing.Point(102, 188);
            this.cmbNombreCliente.Name = "cmbNombreCliente";
            this.cmbNombreCliente.Size = new System.Drawing.Size(257, 25);
            this.cmbNombreCliente.TabIndex = 33;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(99, 150);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(142, 18);
            this.lblNombreCliente.TabIndex = 32;
            this.lblNombreCliente.Text = "Nombre del cliente";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTelefono.Location = new System.Drawing.Point(565, 433);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(285, 20);
            this.txtTelefono.TabIndex = 36;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(562, 393);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(135, 17);
            this.lblTelefono.TabIndex = 39;
            this.lblTelefono.Text = "Número de télefono";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Location = new System.Drawing.Point(565, 281);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDomicilio.MaxLength = 80;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(285, 20);
            this.txtDomicilio.TabIndex = 34;
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(562, 318);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(54, 17);
            this.lblCiudad.TabIndex = 38;
            this.lblCiudad.Text = "Ciudad";
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.Location = new System.Drawing.Point(562, 248);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(68, 17);
            this.lblDirección.TabIndex = 37;
            this.lblDirección.Text = "Domicilio";
            // 
            // lblDatosCli
            // 
            this.lblDatosCli.AutoSize = true;
            this.lblDatosCli.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosCli.Location = new System.Drawing.Point(562, 132);
            this.lblDatosCli.Name = "lblDatosCli";
            this.lblDatosCli.Size = new System.Drawing.Size(131, 18);
            this.lblDatosCli.TabIndex = 40;
            this.lblDatosCli.Text = "Datos del cliente:";
            // 
            // txtClaveCliente
            // 
            this.txtClaveCliente.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtClaveCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClaveCliente.Enabled = false;
            this.txtClaveCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveCliente.Location = new System.Drawing.Point(565, 209);
            this.txtClaveCliente.Name = "txtClaveCliente";
            this.txtClaveCliente.ReadOnly = true;
            this.txtClaveCliente.Size = new System.Drawing.Size(229, 24);
            this.txtClaveCliente.TabIndex = 41;
            // 
            // lblClaveCliente
            // 
            this.lblClaveCliente.AutoSize = true;
            this.lblClaveCliente.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCliente.Location = new System.Drawing.Point(562, 173);
            this.lblClaveCliente.Name = "lblClaveCliente";
            this.lblClaveCliente.Size = new System.Drawing.Size(45, 17);
            this.lblClaveCliente.TabIndex = 42;
            this.lblClaveCliente.Text = "Clave";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCiudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.Location = new System.Drawing.Point(565, 353);
            this.txtCiudad.MaxLength = 60;
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.ReadOnly = true;
            this.txtCiudad.Size = new System.Drawing.Size(229, 24);
            this.txtCiudad.TabIndex = 43;
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 583);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.txtClaveCliente);
            this.Controls.Add(this.lblClaveCliente);
            this.Controls.Add(this.lblDatosCli);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.lblCiudad);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.cmbNombreCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.panelDiv);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmEditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarCliente";
            this.Load += new System.EventHandler(this.FrmEditarCliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsGuardarEdicion;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelDiv;
        private System.Windows.Forms.ComboBox cmbNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.Label lblDatosCli;
        private System.Windows.Forms.TextBox txtClaveCliente;
        private System.Windows.Forms.Label lblClaveCliente;
        private System.Windows.Forms.TextBox txtCiudad;
    }
}