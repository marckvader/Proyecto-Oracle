namespace Ferreteria.Presentacion
{
    partial class FRMTipo_Cia
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
            this.TABGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.CHKSeleccionar = new System.Windows.Forms.CheckBox();
            this.GBTipoEmpresa = new System.Windows.Forms.GroupBox();
            this.TXTBuscar = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNListar = new System.Windows.Forms.Button();
            this.DGVLTipoEmpresa = new System.Windows.Forms.DataGridView();
            this.SELECCIONAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.TXTTipoEmpresa = new System.Windows.Forms.TextBox();
            this.TXTCodEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTNSalir = new System.Windows.Forms.Button();
            this.TABGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBTipoEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLTipoEmpresa)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TABGeneral
            // 
            this.TABGeneral.Controls.Add(this.tabPage1);
            this.TABGeneral.Controls.Add(this.tabPage2);
            this.TABGeneral.Location = new System.Drawing.Point(12, 12);
            this.TABGeneral.Name = "TABGeneral";
            this.TABGeneral.SelectedIndex = 0;
            this.TABGeneral.Size = new System.Drawing.Size(460, 274);
            this.TABGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblTotal);
            this.tabPage1.Controls.Add(this.BTNEliminar);
            this.tabPage1.Controls.Add(this.CHKSeleccionar);
            this.tabPage1.Controls.Add(this.GBTipoEmpresa);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(105, 217);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(99, 13);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "Total de Registros: ";
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(351, 213);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 2;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // CHKSeleccionar
            // 
            this.CHKSeleccionar.AutoSize = true;
            this.CHKSeleccionar.Location = new System.Drawing.Point(7, 217);
            this.CHKSeleccionar.Name = "CHKSeleccionar";
            this.CHKSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.CHKSeleccionar.TabIndex = 1;
            this.CHKSeleccionar.Text = "Seleccionar";
            this.CHKSeleccionar.UseVisualStyleBackColor = true;
            this.CHKSeleccionar.CheckedChanged += new System.EventHandler(this.CHKSeleccionar_CheckedChanged);
            // 
            // GBTipoEmpresa
            // 
            this.GBTipoEmpresa.Controls.Add(this.TXTBuscar);
            this.GBTipoEmpresa.Controls.Add(this.BTNBuscar);
            this.GBTipoEmpresa.Controls.Add(this.BTNListar);
            this.GBTipoEmpresa.Controls.Add(this.DGVLTipoEmpresa);
            this.GBTipoEmpresa.Location = new System.Drawing.Point(6, 6);
            this.GBTipoEmpresa.Name = "GBTipoEmpresa";
            this.GBTipoEmpresa.Size = new System.Drawing.Size(426, 204);
            this.GBTipoEmpresa.TabIndex = 0;
            this.GBTipoEmpresa.TabStop = false;
            this.GBTipoEmpresa.Text = "Definición Tipo Empresa";
            // 
            // TXTBuscar
            // 
            this.TXTBuscar.Location = new System.Drawing.Point(88, 66);
            this.TXTBuscar.Name = "TXTBuscar";
            this.TXTBuscar.Size = new System.Drawing.Size(332, 20);
            this.TXTBuscar.TabIndex = 3;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(6, 64);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 2;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNListar
            // 
            this.BTNListar.Location = new System.Drawing.Point(6, 35);
            this.BTNListar.Name = "BTNListar";
            this.BTNListar.Size = new System.Drawing.Size(75, 23);
            this.BTNListar.TabIndex = 1;
            this.BTNListar.Text = "Listar";
            this.BTNListar.UseVisualStyleBackColor = true;
            this.BTNListar.Click += new System.EventHandler(this.BTNListar_Click);
            // 
            // DGVLTipoEmpresa
            // 
            this.DGVLTipoEmpresa.AllowUserToAddRows = false;
            this.DGVLTipoEmpresa.AllowUserToDeleteRows = false;
            this.DGVLTipoEmpresa.AllowUserToOrderColumns = true;
            this.DGVLTipoEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLTipoEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECCIONAR});
            this.DGVLTipoEmpresa.Location = new System.Drawing.Point(0, 109);
            this.DGVLTipoEmpresa.Name = "DGVLTipoEmpresa";
            this.DGVLTipoEmpresa.ReadOnly = true;
            this.DGVLTipoEmpresa.Size = new System.Drawing.Size(420, 95);
            this.DGVLTipoEmpresa.TabIndex = 0;
            this.DGVLTipoEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLTipoEmpresa_CellContentClick);
            this.DGVLTipoEmpresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLTipoEmpresa_CellDoubleClick);
            // 
            // SELECCIONAR
            // 
            this.SELECCIONAR.HeaderText = "SELECCIONAR";
            this.SELECCIONAR.Name = "SELECCIONAR";
            this.SELECCIONAR.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TXTDescripcion);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BTNCancelar);
            this.tabPage2.Controls.Add(this.BTNActualizar);
            this.tabPage2.Controls.Add(this.BTNGuardar);
            this.tabPage2.Controls.Add(this.BTNNuevo);
            this.tabPage2.Controls.Add(this.TXTTipoEmpresa);
            this.tabPage2.Controls.Add(this.TXTCodEmpresa);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.Location = new System.Drawing.Point(81, 41);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(351, 114);
            this.TXTDescripcion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripción:";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(81, 219);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(351, 23);
            this.BTNCancelar.TabIndex = 7;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(81, 190);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(351, 23);
            this.BTNActualizar.TabIndex = 6;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(260, 161);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(172, 23);
            this.BTNGuardar.TabIndex = 5;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(81, 161);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(164, 23);
            this.BTNNuevo.TabIndex = 4;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // TXTTipoEmpresa
            // 
            this.TXTTipoEmpresa.Location = new System.Drawing.Point(277, 10);
            this.TXTTipoEmpresa.Name = "TXTTipoEmpresa";
            this.TXTTipoEmpresa.Size = new System.Drawing.Size(155, 20);
            this.TXTTipoEmpresa.TabIndex = 3;
            // 
            // TXTCodEmpresa
            // 
            this.TXTCodEmpresa.Location = new System.Drawing.Point(81, 10);
            this.TXTCodEmpresa.Name = "TXTCodEmpresa";
            this.TXTCodEmpresa.Size = new System.Drawing.Size(100, 20);
            this.TXTCodEmpresa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(202, 292);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 1;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // FRMTipo_Cia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.TABGeneral);
            this.Name = "FRMTipo_Cia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definición Tipo Empresas.";
            this.Load += new System.EventHandler(this.FRMTipo_Cia_Load);
            this.TABGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GBTipoEmpresa.ResumeLayout(false);
            this.GBTipoEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLTipoEmpresa)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TABGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox GBTipoEmpresa;
        private System.Windows.Forms.DataGridView DGVLTipoEmpresa;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.CheckBox CHKSeleccionar;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Button BTNListar;
        private System.Windows.Forms.TextBox TXTBuscar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECCIONAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTTipoEmpresa;
        private System.Windows.Forms.TextBox TXTCodEmpresa;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.TextBox TXTDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button BTNSalir;
    }
}