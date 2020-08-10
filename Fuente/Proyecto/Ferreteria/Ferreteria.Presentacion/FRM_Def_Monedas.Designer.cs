namespace Ferreteria.Presentacion
{
    partial class FRM_Def_Monedas
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
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GBMonedas = new System.Windows.Forms.GroupBox();
            this.BTNDesactivar = new System.Windows.Forms.Button();
            this.BTNActivar = new System.Windows.Forms.Button();
            this.CHKSeleccionar = new System.Windows.Forms.CheckBox();
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.BTNListar = new System.Windows.Forms.Button();
            this.TXTBuscar = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.LBLDescripcion = new System.Windows.Forms.Label();
            this.LBLId_Moneda = new System.Windows.Forms.Label();
            this.TXTIdMoneda = new System.Windows.Forms.TextBox();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.TXTSeries = new System.Windows.Forms.TextBox();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.LBLSigla = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBMonedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(12, 12);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(613, 363);
            this.TabGeneral.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GBMonedas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GBMonedas
            // 
            this.GBMonedas.Controls.Add(this.BTNDesactivar);
            this.GBMonedas.Controls.Add(this.BTNActivar);
            this.GBMonedas.Controls.Add(this.CHKSeleccionar);
            this.GBMonedas.Controls.Add(this.DGVListado);
            this.GBMonedas.Controls.Add(this.BTNEliminar);
            this.GBMonedas.Controls.Add(this.BTNListar);
            this.GBMonedas.Controls.Add(this.TXTBuscar);
            this.GBMonedas.Controls.Add(this.BTNBuscar);
            this.GBMonedas.Controls.Add(this.LblTotal);
            this.GBMonedas.Location = new System.Drawing.Point(6, 6);
            this.GBMonedas.Name = "GBMonedas";
            this.GBMonedas.Size = new System.Drawing.Size(593, 325);
            this.GBMonedas.TabIndex = 5;
            this.GBMonedas.TabStop = false;
            this.GBMonedas.Text = "Consulta de Monedas";
            // 
            // BTNDesactivar
            // 
            this.BTNDesactivar.Location = new System.Drawing.Point(87, 296);
            this.BTNDesactivar.Name = "BTNDesactivar";
            this.BTNDesactivar.Size = new System.Drawing.Size(75, 23);
            this.BTNDesactivar.TabIndex = 15;
            this.BTNDesactivar.Text = "Desactivar";
            this.BTNDesactivar.UseVisualStyleBackColor = true;
            // 
            // BTNActivar
            // 
            this.BTNActivar.Location = new System.Drawing.Point(6, 296);
            this.BTNActivar.Name = "BTNActivar";
            this.BTNActivar.Size = new System.Drawing.Size(75, 23);
            this.BTNActivar.TabIndex = 14;
            this.BTNActivar.Text = "Activar";
            this.BTNActivar.UseVisualStyleBackColor = true;
            // 
            // CHKSeleccionar
            // 
            this.CHKSeleccionar.AutoSize = true;
            this.CHKSeleccionar.Location = new System.Drawing.Point(6, 276);
            this.CHKSeleccionar.Name = "CHKSeleccionar";
            this.CHKSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.CHKSeleccionar.TabIndex = 12;
            this.CHKSeleccionar.Text = "Seleccionar";
            this.CHKSeleccionar.UseVisualStyleBackColor = true;
            this.CHKSeleccionar.CheckedChanged += new System.EventHandler(this.CHKSeleccionar_CheckedChanged);
            // 
            // DGVListado
            // 
            this.DGVListado.AllowUserToAddRows = false;
            this.DGVListado.AllowUserToDeleteRows = false;
            this.DGVListado.AllowUserToOrderColumns = true;
            this.DGVListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DGVListado.Location = new System.Drawing.Point(6, 78);
            this.DGVListado.Name = "DGVListado";
            this.DGVListado.ReadOnly = true;
            this.DGVListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVListado.Size = new System.Drawing.Size(581, 188);
            this.DGVListado.TabIndex = 0;
            this.DGVListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellContentClick);
            this.DGVListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Seleccionar.HeaderText = "SELECCIONAR";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 88;
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(168, 296);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 4;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // BTNListar
            // 
            this.BTNListar.Location = new System.Drawing.Point(6, 20);
            this.BTNListar.Name = "BTNListar";
            this.BTNListar.Size = new System.Drawing.Size(114, 23);
            this.BTNListar.TabIndex = 9;
            this.BTNListar.Text = "Listar";
            this.BTNListar.UseVisualStyleBackColor = true;
            this.BTNListar.Click += new System.EventHandler(this.BTNListar_Click);
            // 
            // TXTBuscar
            // 
            this.TXTBuscar.Location = new System.Drawing.Point(126, 51);
            this.TXTBuscar.Name = "TXTBuscar";
            this.TXTBuscar.Size = new System.Drawing.Size(461, 20);
            this.TXTBuscar.TabIndex = 7;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(6, 49);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(114, 23);
            this.BTNBuscar.TabIndex = 6;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(452, 301);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(101, 13);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total Registros: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TXTDescripcion);
            this.tabPage2.Controls.Add(this.LBLDescripcion);
            this.tabPage2.Controls.Add(this.LBLId_Moneda);
            this.tabPage2.Controls.Add(this.TXTIdMoneda);
            this.tabPage2.Controls.Add(this.BTNCancelar);
            this.tabPage2.Controls.Add(this.BTNActualizar);
            this.tabPage2.Controls.Add(this.BTNGuardar);
            this.tabPage2.Controls.Add(this.TXTSeries);
            this.tabPage2.Controls.Add(this.BTNNuevo);
            this.tabPage2.Controls.Add(this.LBLSigla);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(605, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.Location = new System.Drawing.Point(94, 63);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(460, 85);
            this.TXTDescripcion.TabIndex = 5;
            // 
            // LBLDescripcion
            // 
            this.LBLDescripcion.AutoSize = true;
            this.LBLDescripcion.Location = new System.Drawing.Point(18, 66);
            this.LBLDescripcion.Name = "LBLDescripcion";
            this.LBLDescripcion.Size = new System.Drawing.Size(66, 13);
            this.LBLDescripcion.TabIndex = 8;
            this.LBLDescripcion.Text = "Descripción:";
            // 
            // LBLId_Moneda
            // 
            this.LBLId_Moneda.AutoSize = true;
            this.LBLId_Moneda.Location = new System.Drawing.Point(18, 25);
            this.LBLId_Moneda.Name = "LBLId_Moneda";
            this.LBLId_Moneda.Size = new System.Drawing.Size(63, 13);
            this.LBLId_Moneda.TabIndex = 7;
            this.LBLId_Moneda.Text = "ID Moneda:";
            // 
            // TXTIdMoneda
            // 
            this.TXTIdMoneda.Location = new System.Drawing.Point(94, 22);
            this.TXTIdMoneda.Name = "TXTIdMoneda";
            this.TXTIdMoneda.Size = new System.Drawing.Size(178, 20);
            this.TXTIdMoneda.TabIndex = 6;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(194, 260);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(216, 23);
            this.BTNCancelar.TabIndex = 5;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(194, 222);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(216, 23);
            this.BTNActualizar.TabIndex = 2;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(317, 183);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(93, 23);
            this.BTNGuardar.TabIndex = 3;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // TXTSeries
            // 
            this.TXTSeries.Location = new System.Drawing.Point(353, 22);
            this.TXTSeries.Name = "TXTSeries";
            this.TXTSeries.Size = new System.Drawing.Size(201, 20);
            this.TXTSeries.TabIndex = 4;
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(194, 183);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(103, 23);
            this.BTNNuevo.TabIndex = 1;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // LBLSigla
            // 
            this.LBLSigla.AutoSize = true;
            this.LBLSigla.Location = new System.Drawing.Point(314, 25);
            this.LBLSigla.Name = "LBLSigla";
            this.LBLSigla.Size = new System.Drawing.Size(33, 13);
            this.LBLSigla.TabIndex = 3;
            this.LBLSigla.Text = "Sigla:";
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(240, 381);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(152, 28);
            this.BTNSalir.TabIndex = 12;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // FRM_Def_Monedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 421);
            this.Controls.Add(this.TabGeneral);
            this.Controls.Add(this.BTNSalir);
            this.Name = "FRM_Def_Monedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Monedas";
            this.Load += new System.EventHandler(this.FRM_Def_Monedas_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GBMonedas.ResumeLayout(false);
            this.GBMonedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox GBMonedas;
        private System.Windows.Forms.CheckBox CHKSeleccionar;
        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Button BTNListar;
        private System.Windows.Forms.TextBox TXTBuscar;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LBLId_Moneda;
        private System.Windows.Forms.TextBox TXTIdMoneda;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.TextBox TXTSeries;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Label LBLSigla;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.TextBox TXTDescripcion;
        private System.Windows.Forms.Label LBLDescripcion;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.Button BTNDesactivar;
        private System.Windows.Forms.Button BTNActivar;
    }
}