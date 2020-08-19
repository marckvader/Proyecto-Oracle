namespace Ferreteria.Presentacion
{
    partial class FRM_DATOS_EMPRESA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_DATOS_EMPRESA));
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GBListado = new System.Windows.Forms.GroupBox();
            this.CHKSeleccionar = new System.Windows.Forms.CheckBox();
            this.TXTBuscar = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TXTEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TXTWeb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TXTCp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MTXTTelefono2 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MTXTFax = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MTXTTelefono1 = new System.Windows.Forms.MaskedTextBox();
            this.CMBProvincia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBTipoID = new System.Windows.Forms.ComboBox();
            this.LBLTipoID = new System.Windows.Forms.Label();
            this.LBLTipocia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBTipoEmpresa = new System.Windows.Forms.ComboBox();
            this.LBLIndicacion = new System.Windows.Forms.Label();
            this.TXTDireccion = new System.Windows.Forms.TextBox();
            this.LBLDescripcion = new System.Windows.Forms.Label();
            this.TXTIdentificacion = new System.Windows.Forms.TextBox();
            this.TXTCodigo = new System.Windows.Forms.TextBox();
            this.LBLCodigo = new System.Windows.Forms.Label();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSBNuevo = new System.Windows.Forms.ToolStripButton();
            this.TSBBuscar = new System.Windows.Forms.ToolStripButton();
            this.TSBGuardar = new System.Windows.Forms.ToolStripButton();
            this.TSBActualizar = new System.Windows.Forms.ToolStripButton();
            this.TSBEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBActivar = new System.Windows.Forms.ToolStripButton();
            this.TSBDesactivar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBPrimero = new System.Windows.Forms.ToolStripButton();
            this.TSBAnterior = new System.Windows.Forms.ToolStripButton();
            this.TSBSiguiente = new System.Windows.Forms.ToolStripButton();
            this.TSBUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBSalir = new System.Windows.Forms.ToolStripButton();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBListado.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(12, 242);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(944, 260);
            this.TabGeneral.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GBListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GBListado
            // 
            this.GBListado.Controls.Add(this.CHKSeleccionar);
            this.GBListado.Controls.Add(this.TXTBuscar);
            this.GBListado.Controls.Add(this.BTNBuscar);
            this.GBListado.Location = new System.Drawing.Point(6, 6);
            this.GBListado.Name = "GBListado";
            this.GBListado.Size = new System.Drawing.Size(924, 222);
            this.GBListado.TabIndex = 1;
            this.GBListado.TabStop = false;
            this.GBListado.Text = "Listado y Consulta de Datos";
            // 
            // CHKSeleccionar
            // 
            this.CHKSeleccionar.AutoSize = true;
            this.CHKSeleccionar.Location = new System.Drawing.Point(426, 143);
            this.CHKSeleccionar.Name = "CHKSeleccionar";
            this.CHKSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.CHKSeleccionar.TabIndex = 4;
            this.CHKSeleccionar.Text = "Seleccionar";
            this.CHKSeleccionar.UseVisualStyleBackColor = true;
            this.CHKSeleccionar.CheckedChanged += new System.EventHandler(this.CHKSeleccionar_CheckedChanged);
            // 
            // TXTBuscar
            // 
            this.TXTBuscar.Location = new System.Drawing.Point(334, 91);
            this.TXTBuscar.Name = "TXTBuscar";
            this.TXTBuscar.Size = new System.Drawing.Size(340, 20);
            this.TXTBuscar.TabIndex = 3;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(253, 88);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 2;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TXTEmail);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TXTWeb);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.TXTCp);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.MTXTTelefono2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.MTXTFax);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.MTXTTelefono1);
            this.tabPage2.Controls.Add(this.CMBProvincia);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.TXTNombre);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.TXTRazonSocial);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.CMBTipoID);
            this.tabPage2.Controls.Add(this.LBLTipoID);
            this.tabPage2.Controls.Add(this.LBLTipocia);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.CMBTipoEmpresa);
            this.tabPage2.Controls.Add(this.LBLIndicacion);
            this.tabPage2.Controls.Add(this.TXTDireccion);
            this.tabPage2.Controls.Add(this.LBLDescripcion);
            this.tabPage2.Controls.Add(this.TXTIdentificacion);
            this.tabPage2.Controls.Add(this.TXTCodigo);
            this.tabPage2.Controls.Add(this.LBLCodigo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "General";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TXTEmail
            // 
            this.TXTEmail.Location = new System.Drawing.Point(541, 182);
            this.TXTEmail.Name = "TXTEmail";
            this.TXTEmail.Size = new System.Drawing.Size(389, 20);
            this.TXTEmail.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "EMAIL:";
            // 
            // TXTWeb
            // 
            this.TXTWeb.Location = new System.Drawing.Point(128, 182);
            this.TXTWeb.Name = "TXTWeb";
            this.TXTWeb.Size = new System.Drawing.Size(350, 20);
            this.TXTWeb.TabIndex = 14;
            this.TXTWeb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTWeb_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "WEB:";
            // 
            // TXTCp
            // 
            this.TXTCp.Location = new System.Drawing.Point(837, 156);
            this.TXTCp.Name = "TXTCp";
            this.TXTCp.Size = new System.Drawing.Size(93, 20);
            this.TXTCp.TabIndex = 13;
            this.TXTCp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCp_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(810, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "CP:";
            // 
            // MTXTTelefono2
            // 
            this.MTXTTelefono2.Location = new System.Drawing.Point(391, 156);
            this.MTXTTelefono2.Mask = "(999) 0000-0000";
            this.MTXTTelefono2.Name = "MTXTTelefono2";
            this.MTXTTelefono2.Size = new System.Drawing.Size(168, 20);
            this.MTXTTelefono2.TabIndex = 11;
            this.MTXTTelefono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTXTTelefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTXTTelefono2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "TELÉFONO:";
            // 
            // MTXTFax
            // 
            this.MTXTFax.Location = new System.Drawing.Point(626, 156);
            this.MTXTFax.Mask = "(999) 0000-0000";
            this.MTXTFax.Name = "MTXTFax";
            this.MTXTFax.Size = new System.Drawing.Size(168, 20);
            this.MTXTFax.TabIndex = 12;
            this.MTXTFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTXTFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTXTFax_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(580, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "FAX:";
            // 
            // MTXTTelefono1
            // 
            this.MTXTTelefono1.Location = new System.Drawing.Point(128, 156);
            this.MTXTTelefono1.Mask = "(999) 0000-0000";
            this.MTXTTelefono1.Name = "MTXTTelefono1";
            this.MTXTTelefono1.Size = new System.Drawing.Size(168, 20);
            this.MTXTTelefono1.TabIndex = 10;
            this.MTXTTelefono1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MTXTTelefono1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MTXTTelefono1_KeyPress);
            // 
            // CMBProvincia
            // 
            this.CMBProvincia.FormattingEnabled = true;
            this.CMBProvincia.ItemHeight = 13;
            this.CMBProvincia.Location = new System.Drawing.Point(752, 70);
            this.CMBProvincia.Name = "CMBProvincia";
            this.CMBProvincia.Size = new System.Drawing.Size(178, 21);
            this.CMBProvincia.TabIndex = 8;
            this.CMBProvincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBProvincia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "PROVINCIA:";
            // 
            // TXTNombre
            // 
            this.TXTNombre.Location = new System.Drawing.Point(128, 70);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(517, 20);
            this.TXTNombre.TabIndex = 7;
            this.TXTNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTNombre_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "NOMBRE:";
            // 
            // TXTRazonSocial
            // 
            this.TXTRazonSocial.Location = new System.Drawing.Point(413, 44);
            this.TXTRazonSocial.Name = "TXTRazonSocial";
            this.TXTRazonSocial.Size = new System.Drawing.Size(517, 20);
            this.TXTRazonSocial.TabIndex = 6;
            this.TXTRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTRazonSocial_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "RAZÓN SOCIAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nº IDENTIFICACIÓN:";
            // 
            // CMBTipoID
            // 
            this.CMBTipoID.FormattingEnabled = true;
            this.CMBTipoID.Location = new System.Drawing.Point(752, 18);
            this.CMBTipoID.Name = "CMBTipoID";
            this.CMBTipoID.Size = new System.Drawing.Size(178, 21);
            this.CMBTipoID.TabIndex = 4;
            this.CMBTipoID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBTipoID_KeyPress);
            // 
            // LBLTipoID
            // 
            this.LBLTipoID.AutoSize = true;
            this.LBLTipoID.Location = new System.Drawing.Point(623, 21);
            this.LBLTipoID.Name = "LBLTipoID";
            this.LBLTipoID.Size = new System.Drawing.Size(123, 13);
            this.LBLTipoID.TabIndex = 14;
            this.LBLTipoID.Text = "TIPO IDENTIFICACIÓN:";
            // 
            // LBLTipocia
            // 
            this.LBLTipocia.AutoSize = true;
            this.LBLTipocia.Location = new System.Drawing.Point(318, 21);
            this.LBLTipocia.Name = "LBLTipocia";
            this.LBLTipocia.Size = new System.Drawing.Size(90, 13);
            this.LBLTipocia.TabIndex = 13;
            this.LBLTipocia.Text = "TIPO EMPRESA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "DIRECCIÓN:";
            // 
            // CMBTipoEmpresa
            // 
            this.CMBTipoEmpresa.FormattingEnabled = true;
            this.CMBTipoEmpresa.Location = new System.Drawing.Point(414, 18);
            this.CMBTipoEmpresa.Name = "CMBTipoEmpresa";
            this.CMBTipoEmpresa.Size = new System.Drawing.Size(168, 21);
            this.CMBTipoEmpresa.TabIndex = 3;
            this.CMBTipoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CMBTipoEmpresa_KeyPress);
            // 
            // LBLIndicacion
            // 
            this.LBLIndicacion.AutoSize = true;
            this.LBLIndicacion.Location = new System.Drawing.Point(753, 212);
            this.LBLIndicacion.Name = "LBLIndicacion";
            this.LBLIndicacion.Size = new System.Drawing.Size(175, 13);
            this.LBLIndicacion.TabIndex = 10;
            this.LBLIndicacion.Text = "(*) Indica que el dato es Obligatorio.";
            // 
            // TXTDireccion
            // 
            this.TXTDireccion.Location = new System.Drawing.Point(128, 96);
            this.TXTDireccion.Multiline = true;
            this.TXTDireccion.Name = "TXTDireccion";
            this.TXTDireccion.Size = new System.Drawing.Size(802, 53);
            this.TXTDireccion.TabIndex = 9;
            this.TXTDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTDireccion_KeyPress);
            // 
            // LBLDescripcion
            // 
            this.LBLDescripcion.AutoSize = true;
            this.LBLDescripcion.Location = new System.Drawing.Point(55, 159);
            this.LBLDescripcion.Name = "LBLDescripcion";
            this.LBLDescripcion.Size = new System.Drawing.Size(67, 13);
            this.LBLDescripcion.TabIndex = 4;
            this.LBLDescripcion.Text = "TELÉFONO:";
            // 
            // TXTIdentificacion
            // 
            this.TXTIdentificacion.Location = new System.Drawing.Point(128, 44);
            this.TXTIdentificacion.Name = "TXTIdentificacion";
            this.TXTIdentificacion.Size = new System.Drawing.Size(184, 20);
            this.TXTIdentificacion.TabIndex = 5;
            this.TXTIdentificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTIdentificacion_KeyPress);
            // 
            // TXTCodigo
            // 
            this.TXTCodigo.Location = new System.Drawing.Point(128, 18);
            this.TXTCodigo.Name = "TXTCodigo";
            this.TXTCodigo.Size = new System.Drawing.Size(184, 20);
            this.TXTCodigo.TabIndex = 2;
            this.TXTCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTCodigo_KeyPress);
            // 
            // LBLCodigo
            // 
            this.LBLCodigo.AutoSize = true;
            this.LBLCodigo.Location = new System.Drawing.Point(15, 21);
            this.LBLCodigo.Name = "LBLCodigo";
            this.LBLCodigo.Size = new System.Drawing.Size(107, 13);
            this.LBLCodigo.TabIndex = 0;
            this.LBLCodigo.Text = "CÓDIGO EMPRESA:";
            // 
            // DGVListado
            // 
            this.DGVListado.AllowUserToAddRows = false;
            this.DGVListado.AllowUserToDeleteRows = false;
            this.DGVListado.AllowUserToOrderColumns = true;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DGVListado.Location = new System.Drawing.Point(8, 28);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.Size = new System.Drawing.Size(944, 208);
            this.DGVListado.TabIndex = 0;
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellContentClick);
            this.DGVListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "SELECCIONAR";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBNuevo,
            this.TSBBuscar,
            this.TSBGuardar,
            this.TSBActualizar,
            this.TSBEliminar,
            this.toolStripSeparator1,
            this.TSBActivar,
            this.TSBDesactivar,
            this.toolStripSeparator2,
            this.TSBPrimero,
            this.TSBAnterior,
            this.TSBSiguiente,
            this.TSBUltimo,
            this.toolStripSeparator3,
            this.TSBSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(968, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TSBNuevo
            // 
            this.TSBNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBNuevo.Image = ((System.Drawing.Image)(resources.GetObject("TSBNuevo.Image")));
            this.TSBNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNuevo.Name = "TSBNuevo";
            this.TSBNuevo.Size = new System.Drawing.Size(23, 22);
            this.TSBNuevo.Text = "toolStripButton1";
            this.TSBNuevo.Click += new System.EventHandler(this.TSBNuevo_Click);
            // 
            // TSBBuscar
            // 
            this.TSBBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBBuscar.Image = ((System.Drawing.Image)(resources.GetObject("TSBBuscar.Image")));
            this.TSBBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBBuscar.Name = "TSBBuscar";
            this.TSBBuscar.Size = new System.Drawing.Size(23, 22);
            this.TSBBuscar.Text = "toolStripButton7";
            // 
            // TSBGuardar
            // 
            this.TSBGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TSBGuardar.Image")));
            this.TSBGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBGuardar.Name = "TSBGuardar";
            this.TSBGuardar.Size = new System.Drawing.Size(23, 22);
            this.TSBGuardar.Text = "toolStripButton2";
            this.TSBGuardar.Click += new System.EventHandler(this.TSBGuardar_Click);
            // 
            // TSBActualizar
            // 
            this.TSBActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBActualizar.Image = ((System.Drawing.Image)(resources.GetObject("TSBActualizar.Image")));
            this.TSBActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBActualizar.Name = "TSBActualizar";
            this.TSBActualizar.Size = new System.Drawing.Size(23, 22);
            this.TSBActualizar.Text = "toolStripButton3";
            // 
            // TSBEliminar
            // 
            this.TSBEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TSBEliminar.Image")));
            this.TSBEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBEliminar.Name = "TSBEliminar";
            this.TSBEliminar.Size = new System.Drawing.Size(23, 22);
            this.TSBEliminar.Text = "toolStripButton4";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBActivar
            // 
            this.TSBActivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBActivar.Image = ((System.Drawing.Image)(resources.GetObject("TSBActivar.Image")));
            this.TSBActivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBActivar.Name = "TSBActivar";
            this.TSBActivar.Size = new System.Drawing.Size(23, 22);
            this.TSBActivar.Text = "toolStripButton5";
            // 
            // TSBDesactivar
            // 
            this.TSBDesactivar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBDesactivar.Image = ((System.Drawing.Image)(resources.GetObject("TSBDesactivar.Image")));
            this.TSBDesactivar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDesactivar.Name = "TSBDesactivar";
            this.TSBDesactivar.Size = new System.Drawing.Size(23, 22);
            this.TSBDesactivar.Text = "toolStripButton6";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBPrimero
            // 
            this.TSBPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBPrimero.Image = ((System.Drawing.Image)(resources.GetObject("TSBPrimero.Image")));
            this.TSBPrimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBPrimero.Name = "TSBPrimero";
            this.TSBPrimero.Size = new System.Drawing.Size(23, 22);
            this.TSBPrimero.Text = "toolStripButton8";
            // 
            // TSBAnterior
            // 
            this.TSBAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBAnterior.Image = ((System.Drawing.Image)(resources.GetObject("TSBAnterior.Image")));
            this.TSBAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBAnterior.Name = "TSBAnterior";
            this.TSBAnterior.Size = new System.Drawing.Size(23, 22);
            this.TSBAnterior.Text = "toolStripButton9";
            // 
            // TSBSiguiente
            // 
            this.TSBSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("TSBSiguiente.Image")));
            this.TSBSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSiguiente.Name = "TSBSiguiente";
            this.TSBSiguiente.Size = new System.Drawing.Size(23, 22);
            this.TSBSiguiente.Text = "toolStripButton10";
            // 
            // TSBUltimo
            // 
            this.TSBUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBUltimo.Image = ((System.Drawing.Image)(resources.GetObject("TSBUltimo.Image")));
            this.TSBUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUltimo.Name = "TSBUltimo";
            this.TSBUltimo.Size = new System.Drawing.Size(23, 22);
            this.TSBUltimo.Text = "toolStripButton11";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBSalir
            // 
            this.TSBSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBSalir.Image = ((System.Drawing.Image)(resources.GetObject("TSBSalir.Image")));
            this.TSBSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSalir.Name = "TSBSalir";
            this.TSBSalir.Size = new System.Drawing.Size(23, 22);
            this.TSBSalir.Text = "toolStripButton12";
            this.TSBSalir.Click += new System.EventHandler(this.TSBSalir_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FRM_DATOS_EMPRESA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 516);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.TabGeneral);
            this.Controls.Add(this.DGVListado);
            this.Name = "FRM_DATOS_EMPRESA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información General de la Empresa";
            this.Load += new System.EventHandler(this.FRM_DATOS_EMPRESA_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GBListado.ResumeLayout(false);
            this.GBListado.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox GBListado;
        private System.Windows.Forms.CheckBox CHKSeleccionar;
        private System.Windows.Forms.TextBox TXTBuscar;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LBLIndicacion;
        private System.Windows.Forms.TextBox TXTDireccion;
        private System.Windows.Forms.Label LBLDescripcion;
        private System.Windows.Forms.TextBox TXTIdentificacion;
        private System.Windows.Forms.TextBox TXTCodigo;
        private System.Windows.Forms.Label LBLCodigo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton TSBNuevo;
        private System.Windows.Forms.ToolStripButton TSBBuscar;
        private System.Windows.Forms.ToolStripButton TSBGuardar;
        private System.Windows.Forms.ToolStripButton TSBActualizar;
        private System.Windows.Forms.ToolStripButton TSBEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSBActivar;
        private System.Windows.Forms.ToolStripButton TSBDesactivar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBPrimero;
        private System.Windows.Forms.ToolStripButton TSBAnterior;
        private System.Windows.Forms.ToolStripButton TSBSiguiente;
        private System.Windows.Forms.ToolStripButton TSBUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSBSalir;
        private System.Windows.Forms.TextBox TXTEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXTWeb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TXTCp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MTXTTelefono2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MTXTFax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MTXTTelefono1;
        private System.Windows.Forms.ComboBox CMBProvincia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBTipoID;
        private System.Windows.Forms.Label LBLTipoID;
        private System.Windows.Forms.Label LBLTipocia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBTipoEmpresa;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
    }
}