using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Negocio;

namespace Ferreteria.Presentacion
{
    public partial class FRMProvincias : Form
    {
        
        public FRMProvincias()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DGVListado.DataSource = NProvincias.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total de Registros: " + Convert.ToString(DGVListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DGVListado.Columns[0].Visible = false;
            DGVListado.Columns[1].Width = 100;
            DGVListado.Columns[1].HeaderText = "CODIGO";
            DGVListado.Columns[2].Width = 141;
            DGVListado.Columns[2].HeaderText = "PROVINCIA"; 
        }
        private void Limpiar()
        {
            TXTId_Provincia.Clear();
            TXTProvincia.Clear();
            BTNGuardar.Visible = true;
            BTNActualizar.Visible = false;
            ErrorIcono.Clear();
            DGVListado.Columns[0].Visible = false;
            DGVListado.Columns[1].Visible = true;
            BTNEliminar.Visible = false;
            CHKSeleccionar.Checked = false;
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Buscar()
        {
            try
            {
                DGVListado.DataSource = NProvincias.Buscar(TXTBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total de Registros: " + Convert.ToString(DGVListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FRMProvincias_Load(object sender, EventArgs e)
        {
            ToolTip textosalir = new ToolTip();
            textosalir.SetToolTip(BTNSalir, "Salir de esta pantalla.");
        }
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            this.Listar();
            TXTId_Provincia.Text = Convert.ToString((DGVListado.Rows.Count)+1);
            TXTProvincia.Focus();
            TXTId_Provincia.Enabled = false;
            TXTId_Provincia.Enabled = false;
            BTNNuevo.Enabled = false;
            BTNGuardar.Enabled = true;
        }
        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = true;
            BTNGuardar.Enabled = false;
            BTNBuscar.Enabled = true;
           
            try 
            {
                string Rpta = "";
                if (TXTProvincia.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTProvincia,"Ingrese el valor");
                }
                else
                {
                    Rpta = NProvincias.Insertar(Convert.ToInt32(TXTId_Provincia.Text), TXTProvincia.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Registro Guardado de Forma Exitosa");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNActualizar.Enabled = true;
            BTNEliminar.Enabled = true;
            this.Buscar();
        }
        private void BTNListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void LblTotal_Click(object sender, EventArgs e)
        {

        }
        private void GBProvincias_Enter(object sender, EventArgs e)
        {

        }
        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }
        private void DGVListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BTNNuevo.Visible = false;
                BTNActualizar.Visible = true;
                BTNGuardar.Visible = false;
                TXTId_Provincia.Text = Convert.ToString(DGVListado.CurrentRow.Cells["ID_PROVINCIA"].Value);
                TXTProvincia.Text = Convert.ToString(DGVListado.CurrentRow.Cells["PROVINCIA"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleciones desde la celda Provincia","SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TXTProvincia.Text == string.Empty || TXTId_Provincia.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTProvincia, "Ingrese el valor");
                }
                else
                {
                    Rpta = NProvincias.Actualizar(Convert.ToInt32(TXTId_Provincia.Text), TXTProvincia.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Registro Actualizado de Forma Exitosa");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void CHKSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKSeleccionar.Checked)
            {
                DGVListado.Columns[0].Visible = true;
                BTNEliminar.Visible = true;
            }
            else 
            {
                DGVListado.Columns[1].Visible = false;
                BTNEliminar.Visible = false;
            }
        }

        private void DGVListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListado.Columns["SELECCIONAR"].Index);
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DGVListado.Rows[e.RowIndex].Cells["SELECCIONAR"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta Seguro que desea eliminar el(los) registro(s)", "Sistema de Ventas", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DGVListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NProvincias.Eliminar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
    }
}
