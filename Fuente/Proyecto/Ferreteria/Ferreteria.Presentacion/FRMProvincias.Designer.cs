﻿namespace Ferreteria.Presentacion
{
    partial class FRMProvincias
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
            this.DGVListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BTNNuevo = new System.Windows.Forms.Button();
            this.BTNActualizar = new System.Windows.Forms.Button();
            this.BTNGuardar = new System.Windows.Forms.Button();
            this.BTNEliminar = new System.Windows.Forms.Button();
            this.GBProvincias = new System.Windows.Forms.GroupBox();
            this.BTNListar = new System.Windows.Forms.Button();
            this.TXTBuscar = new System.Windows.Forms.TextBox();
            this.BTNBuscar = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BTNSalir = new System.Windows.Forms.Button();
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LBLId_Provincia = new System.Windows.Forms.Label();
            this.TXTId_Provincia = new System.Windows.Forms.TextBox();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.TXTProvincia = new System.Windows.Forms.TextBox();
            this.LBLProvincia = new System.Windows.Forms.Label();
            this.ErrorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.CHKSeleccionar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).BeginInit();
            this.GBProvincias.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).BeginInit();
            this.SuspendLayout();
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
            this.DGVListado.Size = new System.Drawing.Size(389, 87);
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
            // BTNNuevo
            // 
            this.BTNNuevo.Location = new System.Drawing.Point(94, 135);
            this.BTNNuevo.Name = "BTNNuevo";
            this.BTNNuevo.Size = new System.Drawing.Size(103, 23);
            this.BTNNuevo.TabIndex = 1;
            this.BTNNuevo.Text = "Nuevo";
            this.BTNNuevo.UseVisualStyleBackColor = true;
            this.BTNNuevo.Click += new System.EventHandler(this.BTNNuevo_Click);
            // 
            // BTNActualizar
            // 
            this.BTNActualizar.Location = new System.Drawing.Point(94, 174);
            this.BTNActualizar.Name = "BTNActualizar";
            this.BTNActualizar.Size = new System.Drawing.Size(216, 23);
            this.BTNActualizar.TabIndex = 2;
            this.BTNActualizar.Text = "Actualizar";
            this.BTNActualizar.UseVisualStyleBackColor = true;
            this.BTNActualizar.Click += new System.EventHandler(this.BTNActualizar_Click);
            // 
            // BTNGuardar
            // 
            this.BTNGuardar.Location = new System.Drawing.Point(217, 135);
            this.BTNGuardar.Name = "BTNGuardar";
            this.BTNGuardar.Size = new System.Drawing.Size(93, 23);
            this.BTNGuardar.TabIndex = 3;
            this.BTNGuardar.Text = "Guardar";
            this.BTNGuardar.UseVisualStyleBackColor = true;
            this.BTNGuardar.Click += new System.EventHandler(this.BTNGuardar_Click);
            // 
            // BTNEliminar
            // 
            this.BTNEliminar.Location = new System.Drawing.Point(320, 179);
            this.BTNEliminar.Name = "BTNEliminar";
            this.BTNEliminar.Size = new System.Drawing.Size(75, 23);
            this.BTNEliminar.TabIndex = 4;
            this.BTNEliminar.Text = "Eliminar";
            this.BTNEliminar.UseVisualStyleBackColor = true;
            this.BTNEliminar.Click += new System.EventHandler(this.BTNEliminar_Click);
            // 
            // GBProvincias
            // 
            this.GBProvincias.Controls.Add(this.CHKSeleccionar);
            this.GBProvincias.Controls.Add(this.DGVListado);
            this.GBProvincias.Controls.Add(this.BTNEliminar);
            this.GBProvincias.Controls.Add(this.BTNListar);
            this.GBProvincias.Controls.Add(this.TXTBuscar);
            this.GBProvincias.Controls.Add(this.BTNBuscar);
            this.GBProvincias.Controls.Add(this.LblTotal);
            this.GBProvincias.Location = new System.Drawing.Point(6, 6);
            this.GBProvincias.Name = "GBProvincias";
            this.GBProvincias.Size = new System.Drawing.Size(408, 236);
            this.GBProvincias.TabIndex = 5;
            this.GBProvincias.TabStop = false;
            this.GBProvincias.Text = "Consulta de Provincias";
            this.GBProvincias.Enter += new System.EventHandler(this.GBProvincias_Enter);
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
            this.TXTBuscar.Size = new System.Drawing.Size(269, 20);
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
            this.LblTotal.Location = new System.Drawing.Point(266, 211);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(101, 13);
            this.LblTotal.TabIndex = 10;
            this.LblTotal.Text = "Total Registros: ";
            this.LblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // BTNSalir
            // 
            this.BTNSalir.Location = new System.Drawing.Point(142, 303);
            this.BTNSalir.Name = "BTNSalir";
            this.BTNSalir.Size = new System.Drawing.Size(152, 28);
            this.BTNSalir.TabIndex = 8;
            this.BTNSalir.Text = "Salir";
            this.BTNSalir.UseVisualStyleBackColor = true;
            this.BTNSalir.Click += new System.EventHandler(this.BTNSalir_Click);
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPage1);
            this.TabGeneral.Controls.Add(this.tabPage2);
            this.TabGeneral.Location = new System.Drawing.Point(12, 12);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(434, 276);
            this.TabGeneral.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GBProvincias);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(426, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LBLId_Provincia);
            this.tabPage2.Controls.Add(this.TXTId_Provincia);
            this.tabPage2.Controls.Add(this.BTNCancelar);
            this.tabPage2.Controls.Add(this.BTNActualizar);
            this.tabPage2.Controls.Add(this.BTNGuardar);
            this.tabPage2.Controls.Add(this.TXTProvincia);
            this.tabPage2.Controls.Add(this.BTNNuevo);
            this.tabPage2.Controls.Add(this.LBLProvincia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(426, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LBLId_Provincia
            // 
            this.LBLId_Provincia.AutoSize = true;
            this.LBLId_Provincia.Location = new System.Drawing.Point(75, 19);
            this.LBLId_Provincia.Name = "LBLId_Provincia";
            this.LBLId_Provincia.Size = new System.Drawing.Size(68, 13);
            this.LBLId_Provincia.TabIndex = 7;
            this.LBLId_Provincia.Text = "ID Provincia:";
            // 
            // TXTId_Provincia
            // 
            this.TXTId_Provincia.Location = new System.Drawing.Point(151, 16);
            this.TXTId_Provincia.Name = "TXTId_Provincia";
            this.TXTId_Provincia.Size = new System.Drawing.Size(178, 20);
            this.TXTId_Provincia.TabIndex = 6;
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.Location = new System.Drawing.Point(94, 212);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(216, 23);
            this.BTNCancelar.TabIndex = 5;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = true;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // TXTProvincia
            // 
            this.TXTProvincia.Location = new System.Drawing.Point(151, 66);
            this.TXTProvincia.Name = "TXTProvincia";
            this.TXTProvincia.Size = new System.Drawing.Size(178, 20);
            this.TXTProvincia.TabIndex = 4;
            // 
            // LBLProvincia
            // 
            this.LBLProvincia.AutoSize = true;
            this.LBLProvincia.Location = new System.Drawing.Point(89, 69);
            this.LBLProvincia.Name = "LBLProvincia";
            this.LBLProvincia.Size = new System.Drawing.Size(54, 13);
            this.LBLProvincia.TabIndex = 3;
            this.LBLProvincia.Text = "Provincia:";
            // 
            // ErrorIcono
            // 
            this.ErrorIcono.ContainerControl = this;
            // 
            // CHKSeleccionar
            // 
            this.CHKSeleccionar.AutoSize = true;
            this.CHKSeleccionar.Location = new System.Drawing.Point(6, 183);
            this.CHKSeleccionar.Name = "CHKSeleccionar";
            this.CHKSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.CHKSeleccionar.TabIndex = 12;
            this.CHKSeleccionar.Text = "Seleccionar";
            this.CHKSeleccionar.UseVisualStyleBackColor = true;
            this.CHKSeleccionar.CheckedChanged += new System.EventHandler(this.CHKSeleccionar_CheckedChanged);
            // 
            // FRMProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 343);
            this.Controls.Add(this.TabGeneral);
            this.Controls.Add(this.BTNSalir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMProvincias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provincias";
            this.Load += new System.EventHandler(this.FRMProvincias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVListado)).EndInit();
            this.GBProvincias.ResumeLayout(false);
            this.GBProvincias.PerformLayout();
            this.TabGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVListado;
        private System.Windows.Forms.Button BTNNuevo;
        private System.Windows.Forms.Button BTNActualizar;
        private System.Windows.Forms.Button BTNGuardar;
        private System.Windows.Forms.Button BTNEliminar;
        private System.Windows.Forms.GroupBox GBProvincias;
        private System.Windows.Forms.Button BTNBuscar;
        private System.Windows.Forms.TextBox TXTBuscar;
        private System.Windows.Forms.Button BTNSalir;
        private System.Windows.Forms.Button BTNListar;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label LBLId_Provincia;
        private System.Windows.Forms.TextBox TXTId_Provincia;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.TextBox TXTProvincia;
        private System.Windows.Forms.Label LBLProvincia;
        private System.Windows.Forms.ErrorProvider ErrorIcono;
        private System.Windows.Forms.CheckBox CHKSeleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
    }
}