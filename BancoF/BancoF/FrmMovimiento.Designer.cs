namespace BancoF
{
    partial class FrmMovimiento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovimiento));
            this.rdDeposito = new System.Windows.Forms.RadioButton();
            this.rdRetiro = new System.Windows.Forms.RadioButton();
            this.grpTipoMovimiento = new System.Windows.Forms.GroupBox();
            this.lblClaveCuenta = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.epMovimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDateTimeNow = new System.Windows.Forms.Label();
            this.lbMovimiento = new System.Windows.Forms.Label();
            this.panelDiv = new System.Windows.Forms.Panel();
            this.msMovimiento = new System.Windows.Forms.MenuStrip();
            this.tsTecBank = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrarRealizarMovimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTipM = new System.Windows.Forms.ToolTip(this.components);
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grpTipoMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMovimiento)).BeginInit();
            this.msMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdDeposito
            // 
            this.rdDeposito.AutoSize = true;
            this.rdDeposito.Checked = true;
            this.rdDeposito.FlatAppearance.BorderSize = 0;
            this.rdDeposito.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.rdDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdDeposito.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDeposito.Location = new System.Drawing.Point(36, 45);
            this.rdDeposito.Name = "rdDeposito";
            this.rdDeposito.Size = new System.Drawing.Size(89, 25);
            this.rdDeposito.TabIndex = 0;
            this.rdDeposito.TabStop = true;
            this.rdDeposito.Text = "Deposito";
            this.rdDeposito.UseVisualStyleBackColor = true;
            // 
            // rdRetiro
            // 
            this.rdRetiro.AutoSize = true;
            this.rdRetiro.FlatAppearance.BorderSize = 0;
            this.rdRetiro.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.rdRetiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdRetiro.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdRetiro.Location = new System.Drawing.Point(36, 75);
            this.rdRetiro.Name = "rdRetiro";
            this.rdRetiro.Size = new System.Drawing.Size(69, 25);
            this.rdRetiro.TabIndex = 1;
            this.rdRetiro.TabStop = true;
            this.rdRetiro.Text = "Retiro";
            this.rdRetiro.UseVisualStyleBackColor = true;
            // 
            // grpTipoMovimiento
            // 
            this.grpTipoMovimiento.Controls.Add(this.rdRetiro);
            this.grpTipoMovimiento.Controls.Add(this.rdDeposito);
            this.grpTipoMovimiento.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipoMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.grpTipoMovimiento.Location = new System.Drawing.Point(104, 163);
            this.grpTipoMovimiento.Name = "grpTipoMovimiento";
            this.grpTipoMovimiento.Size = new System.Drawing.Size(212, 126);
            this.grpTipoMovimiento.TabIndex = 6;
            this.grpTipoMovimiento.TabStop = false;
            this.grpTipoMovimiento.Text = "Tipo de movimiento";
            // 
            // lblClaveCuenta
            // 
            this.lblClaveCuenta.AutoSize = true;
            this.lblClaveCuenta.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblClaveCuenta.Location = new System.Drawing.Point(385, 163);
            this.lblClaveCuenta.Name = "lblClaveCuenta";
            this.lblClaveCuenta.Size = new System.Drawing.Size(171, 25);
            this.lblClaveCuenta.TabIndex = 7;
            this.lblClaveCuenta.Text = "Clave de la cuenta";
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtClave.Location = new System.Drawing.Point(424, 204);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(412, 19);
            this.txtClave.TabIndex = 8;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtMonto.Location = new System.Drawing.Point(424, 310);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(412, 19);
            this.txtMonto.TabIndex = 10;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.txtMonto.Validated += new System.EventHandler(this.txtMonto_Validated);
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblMonto.Location = new System.Drawing.Point(387, 270);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(73, 25);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "Monto";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombre.Location = new System.Drawing.Point(424, 424);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(412, 19);
            this.txtNombre.TabIndex = 12;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblNombre.Location = new System.Drawing.Point(387, 383);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(363, 25);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre de quien realiza el movimiento";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.btnLimpiar.Location = new System.Drawing.Point(795, 531);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(113, 37);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(976, -2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 28);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "x";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // epMovimiento
            // 
            this.epMovimiento.ContainerControl = this;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblFecha.Location = new System.Drawing.Point(121, 339);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(69, 24);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDateTimeNow
            // 
            this.lblDateTimeNow.AutoSize = true;
            this.lblDateTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDateTimeNow.Location = new System.Drawing.Point(136, 377);
            this.lblDateTimeNow.Name = "lblDateTimeNow";
            this.lblDateTimeNow.Size = new System.Drawing.Size(14, 20);
            this.lblDateTimeNow.TabIndex = 19;
            this.lblDateTimeNow.Text = "-";
            // 
            // lbMovimiento
            // 
            this.lbMovimiento.AutoSize = true;
            this.lbMovimiento.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(48)))), ((int)(((byte)(36)))));
            this.lbMovimiento.Location = new System.Drawing.Point(42, 59);
            this.lbMovimiento.Name = "lbMovimiento";
            this.lbMovimiento.Size = new System.Drawing.Size(252, 54);
            this.lbMovimiento.TabIndex = 20;
            this.lbMovimiento.Text = "Movimiento";
            // 
            // panelDiv
            // 
            this.panelDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(36)))), ((int)(((byte)(20)))));
            this.panelDiv.Location = new System.Drawing.Point(0, 555);
            this.panelDiv.Name = "panelDiv";
            this.panelDiv.Size = new System.Drawing.Size(1024, 112);
            this.panelDiv.TabIndex = 28;
            // 
            // msMovimiento
            // 
            this.msMovimiento.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Bold);
            this.msMovimiento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTecBank});
            this.msMovimiento.Location = new System.Drawing.Point(0, 0);
            this.msMovimiento.Name = "msMovimiento";
            this.msMovimiento.Size = new System.Drawing.Size(1000, 27);
            this.msMovimiento.TabIndex = 34;
            this.msMovimiento.Text = "menuStrip1";
            // 
            // tsTecBank
            // 
            this.tsTecBank.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarMovimientoToolStripMenuItem,
            this.tsCerrarRealizarMovimiento,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.tsTecBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tsTecBank.Name = "tsTecBank";
            this.tsTecBank.Size = new System.Drawing.Size(77, 23);
            this.tsTecBank.Text = "TecBank";
            // 
            // realizarMovimientoToolStripMenuItem
            // 
            this.realizarMovimientoToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.realizarMovimientoToolStripMenuItem.Name = "realizarMovimientoToolStripMenuItem";
            this.realizarMovimientoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.realizarMovimientoToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.realizarMovimientoToolStripMenuItem.Text = "Realizar Movimiento";
            this.realizarMovimientoToolStripMenuItem.Click += new System.EventHandler(this.realizarMovimientoToolStripMenuItem_Click_1);
            // 
            // tsCerrarRealizarMovimiento
            // 
            this.tsCerrarRealizarMovimiento.Font = new System.Drawing.Font("Ebrima", 10F);
            this.tsCerrarRealizarMovimiento.Name = "tsCerrarRealizarMovimiento";
            this.tsCerrarRealizarMovimiento.Size = new System.Drawing.Size(245, 24);
            this.tsCerrarRealizarMovimiento.Text = "Cerrar Realizar Movimiento";
            this.tsCerrarRealizarMovimiento.Click += new System.EventHandler(this.tsCerrarRealizarMovimiento_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 10F);
            this.salirToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Ebrima", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.lblSaldo.Location = new System.Drawing.Point(611, 238);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 19);
            this.lblSaldo.TabIndex = 35;
            // 
            // FrmMovimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lbMovimiento);
            this.Controls.Add(this.lblDateTimeNow);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClaveCuenta);
            this.Controls.Add(this.grpTipoMovimiento);
            this.Controls.Add(this.panelDiv);
            this.Controls.Add(this.msMovimiento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMovimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecBank";
            this.Load += new System.EventHandler(this.FrmMovimiento_Load);
            this.grpTipoMovimiento.ResumeLayout(false);
            this.grpTipoMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMovimiento)).EndInit();
            this.msMovimiento.ResumeLayout(false);
            this.msMovimiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdDeposito;
        private System.Windows.Forms.RadioButton rdRetiro;
        private System.Windows.Forms.GroupBox grpTipoMovimiento;
        private System.Windows.Forms.Label lblClaveCuenta;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider epMovimiento;
        private System.Windows.Forms.Label lblDateTimeNow;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lbMovimiento;
        private System.Windows.Forms.Panel panelDiv;
        private System.Windows.Forms.MenuStrip msMovimiento;
        private System.Windows.Forms.ToolStripMenuItem tsTecBank;
        private System.Windows.Forms.ToolStripMenuItem tsCerrarRealizarMovimiento;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipM;
        private System.Windows.Forms.ToolStripMenuItem realizarMovimientoToolStripMenuItem;
        private System.Windows.Forms.Label lblSaldo;
    }
}