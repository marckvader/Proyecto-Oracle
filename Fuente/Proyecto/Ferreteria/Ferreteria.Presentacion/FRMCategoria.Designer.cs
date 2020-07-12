namespace Ferreteria.Presentacion
{
    partial class FRMCategoria
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
            this.GBListado = new System.Windows.Forms.GroupBox();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.LBLTotal = new System.Windows.Forms.Label();
            this.CHKSeleccionar = new System.Windows.Forms.CheckBox();
            this.TXTBuscar = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.BTNListar = new System.Windows.Forms.Button();
            this.DGVCategoria = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LBLIndicacion = new System.Windows.Forms.Label();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.TXTDescripcion = new System.Windows.Forms.TextBox();
            this.LBLDescripcion = new System.Windows.Forms.Label();
            this.TXTCategoria = new System.Windows.Forms.TextBox();
            this.TXTCodigo = new System.Windows.Forms.TextBox();
            this.LbLCategoria = new System.Windows.Forms.Label();
            this.LBLCodigo = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.BTNSalir = new System.Windows.Forms.Button();
            this.BTNActivar = new System.Windows.Forms.Button();
            this.BTNDesactivar = new System.Windows.Forms.Button();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoria)).BeginInit();
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
            this.TabGeneral.Size = new System.Drawing.Size(776, 474);
            this.TabGeneral.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GBListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GBListado
            // 
            this.GBListado.Controls.Add(this.BTNDesactivar);
            this.GBListado.Controls.Add(this.BTNActivar);
            this.GBListado.Controls.Add(this.BTNEliminar);
            this.GBListado.Controls.Add(this.LBLTotal);
            this.GBListado.Controls.Add(this.CHKSeleccionar);
            this.GBListado.Controls.Add(this.TXTBuscar);
            this.GBListado.Controls.Add(this.BTNBuscar);
            this.GBListado.Controls.Add(this.BTNListar);
            this.GBListado.Controls.Add(this.DGVCategoria);
            this.GBListado.Location = new System.Drawing.Point(6, 6);
            this.GBListado.Name = "GBListado";
            this.GBListado.Size = new System.Drawing.Size(759, 433);
            this.GBListado.TabIndex = 1;
            this.GBListado.TabStop = false;
            this.GBListado.Text = "Listado y Consulta de Datos";
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(584, 387);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 6;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // LBLTotal
            // 
            this.LBLTotal.AutoSize = true;
            this.LBLTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTotal.Location = new System.Drawing.Point(598, 347);
            this.LBLTotal.Name = "LBLTotal";
            this.LBLTotal.Size = new System.Drawing.Size(145, 16);
            this.LBLTotal.TabIndex = 5;
            this.LBLTotal.Text = "Total de Registros: ";
            // 
            // CHKSeleccionar
            // 
            this.CHKSeleccionar.AutoSize = true;
            this.CHKSeleccionar.Location = new System.Drawing.Point(13, 348);
            this.CHKSeleccionar.Name = "CHKSeleccionar";
            this.CHKSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.CHKSeleccionar.TabIndex = 4;
            this.CHKSeleccionar.Text = "Seleccionar";
            this.CHKSeleccionar.UseVisualStyleBackColor = true;
            this.CHKSeleccionar.CheckedChanged += new System.EventHandler(this.CKBSeleccionar_CheckedChanged);
            // 
            // TXTBuscar
            // 
            this.TXTBuscar.Location = new System.Drawing.Point(87, 61);
            this.TXTBuscar.Name = "TXTBuscar";
            this.TXTBuscar.Size = new System.Drawing.Size(340, 20);
            this.TXTBuscar.TabIndex = 3;
            // 
            // BTNBuscar
            // 
            this.BTNBuscar.Location = new System.Drawing.Point(6, 58);
            this.BTNBuscar.Name = "BTNBuscar";
            this.BTNBuscar.Size = new System.Drawing.Size(75, 23);
            this.BTNBuscar.TabIndex = 2;
            this.BTNBuscar.Text = "Buscar";
            this.BTNBuscar.UseVisualStyleBackColor = true;
            this.BTNBuscar.Click += new System.EventHandler(this.BTNBuscar_Click);
            // 
            // BTNListar
            // 
            this.BTNListar.Location = new System.Drawing.Point(6, 29);
            this.BTNListar.Name = "BTNListar";
            this.BTNListar.Size = new System.Drawing.Size(75, 23);
            this.BTNListar.TabIndex = 1;
            this.BTNListar.Text = "Listar";
            this.BTNListar.UseVisualStyleBackColor = true;
            this.BTNListar.Click += new System.EventHandler(this.BTNListar_Click);
            // 
            // DGVCategoria
            // 
            this.DGVCategoria.AllowUserToAddRows = false;
            this.DGVCategoria.AllowUserToDeleteRows = false;
            this.DGVCategoria.AllowUserToOrderColumns = true;
            this.DGVCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DGVCategoria.Location = new System.Drawing.Point(6, 87);
            this.DGVCategoria.Name = "DGVCategoria";
            this.DGVCategoria.ReadOnly = true;
            this.DGVCategoria.Size = new System.Drawing.Size(747, 251);
            this.DGVCategoria.TabIndex = 0;
            this.DGVCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategoria_CellContentClick);
            this.DGVCategoria.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategoria_CellContentDoubleClick);
            this.DGVCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCategoria_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "SELECCIONAR";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LBLIndicacion);
            this.tabPage2.Controls.Add(this.BTNCancelar);
            this.tabPage2.Controls.Add(this.BTNActualizar);
            this.tabPage2.Controls.Add(this.BTNGuardar);
            this.tabPage2.Controls.Add(this.BTNNuevo);
            this.tabPage2.Controls.Add(this.TXTDescripcion);
            this.tabPage2.Controls.Add(this.LBLDescripcion);
            this.tabPage2.Controls.Add(this.TXTCategoria);
            this.tabPage2.Controls.Add(this.TXTCodigo);
            this.tabPage2.Controls.Add(this.LbLCategoria);
            this.tabPage2.Controls.Add(this.LBLCodigo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 448);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LBLIndicacion
            // 
            this.LBLIndicacion.AutoSize = true;
            this.LBLIndicacion.Location = new System.Drawing.Point(295, 218);
            this.LBLIndicacion.Name = "LBLIndicacion";
            this.LBLIndicacion.Size = new System.Drawing.Size(175, 13);
            this.LBLIndicacion.TabIndex = 10;
            this.LBLIndicacion.Text = "(*) Indica que el dato es Obligatorio.";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(195, 383);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(382, 23);
            this.BTNCancelar.TabIndex = 9;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(195, 324);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(382, 23);
            this.BTNActualizar.TabIndex = 8;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(411, 259);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(166, 23);
            this.BTNGuardar.TabIndex = 7;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(195, 259);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(170, 23);
            this.BTNNuevo.TabIndex = 6;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // TXTDescripcion
            // 
            this.TXTDescripcion.Location = new System.Drawing.Point(195, 97);
            this.TXTDescripcion.Multiline = true;
            this.TXTDescripcion.Name = "TXTDescripcion";
            this.TXTDescripcion.Size = new System.Drawing.Size(382, 91);
            this.TXTDescripcion.TabIndex = 5;
            // 
            // LBLDescripcion
            // 
            this.LBLDescripcion.AutoSize = true;
            this.LBLDescripcion.Location = new System.Drawing.Point(106, 100);
            this.LBLDescripcion.Name = "LBLDescripcion";
            this.LBLDescripcion.Size = new System.Drawing.Size(83, 13);
            this.LBLDescripcion.TabIndex = 4;
            this.LBLDescripcion.Text = "DESCRIPCION:";
            // 
            // TXTCategoria
            // 
            this.TXTCategoria.Location = new System.Drawing.Point(195, 71);
            this.TXTCategoria.Name = "TXTCategoria";
            this.TXTCategoria.Size = new System.Drawing.Size(382, 20);
            this.TXTCategoria.TabIndex = 3;
            // 
            // TXTCodigo
            // 
            this.TXTCodigo.Location = new System.Drawing.Point(195, 45);
            this.TXTCodigo.Name = "TXTCodigo";
            this.TXTCodigo.Size = new System.Drawing.Size(100, 20);
            this.TXTCodigo.TabIndex = 2;
            // 
            // LbLCategoria
            // 
            this.LbLCategoria.AutoSize = true;
            this.LbLCategoria.Location = new System.Drawing.Point(104, 74);
            this.LbLCategoria.Name = "LbLCategoria";
            this.LbLCategoria.Size = new System.Drawing.Size(85, 13);
            this.LbLCategoria.TabIndex = 1;
            this.LbLCategoria.Text = "CATEGORÍA (*):";
            // 
            // LBLCodigo
            // 
            this.LBLCodigo.AutoSize = true;
            this.LBLCodigo.Location = new System.Drawing.Point(137, 48);
            this.LBLCodigo.Name = "LBLCodigo";
            this.LBLCodigo.Size = new System.Drawing.Size(52, 13);
            this.LBLCodigo.TabIndex = 0;
            this.LBLCodigo.Text = "CÓDIGO:";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(355, 499);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(75, 23);
            this.BTNSalir.TabIndex = 1;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // BTNActivar
            // 
            this.BTNActivar.Location = new System.Drawing.Point(87, 387);
            this.BTNActivar.Name = "BTNActivar";
            this.BTNActivar.Size = new System.Drawing.Size(75, 23);
            this.BTNActivar.TabIndex = 7;
            this.BTNActivar.Text = "Activar";
            this.BTNActivar.UseVisualStyleBackColor = true;
            this.BTNActivar.Click += new System.EventHandler(this.BTNActivar_Click);
            // 
            // BTNDesactivar
            // 
            this.BTNDesactivar.Location = new System.Drawing.Point(333, 387);
            this.BTNDesactivar.Name = "BTNDesactivar";
            this.BTNDesactivar.Size = new System.Drawing.Size(75, 23);
            this.BTNDesactivar.TabIndex = 8;
            this.BTNDesactivar.Text = "Desactivar";
            this.BTNDesactivar.UseVisualStyleBackColor = true;
            this.BTNDesactivar.Click += new System.EventHandler(this.BTNDesactivar_Click);
            // 
            // FRMCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.BTNSalir);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FRMCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definicion de Categorias de Productos";
            this.Load += new System.EventHandler(this.FRMCategoria_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GBListado.ResumeLayout(false);
            this.GBListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategoria)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox GBListado;
        private System.Windows.Forms.DataGridView DGVCategoria;
        private System.Windows.Forms.TextBox TXTBuscar;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.Button BTNListar;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.CheckBox CHKSeleccionar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.Label LBLTotal;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TextBox TXTCategoria;
        private System.Windows.Forms.TextBox TXTCodigo;
        private System.Windows.Forms.Label LbLCategoria;
        private System.Windows.Forms.Label LBLCodigo;
        private System.Windows.Forms.TextBox TXTDescripcion;
        private System.Windows.Forms.Label LBLDescripcion;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Label LBLIndicacion;
        private System.Windows.Forms.Button BTNDesactivar;
        private System.Windows.Forms.Button BTNActivar;
    }
}