using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria.Negocio;
using System.Windows.Forms;

namespace Ferreteria.Presentacion
{
    public partial class FRMCategoria : Form
    {
        private string NombreAnt;
        public FRMCategoria()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DGVCategoria.DataSource = NCategoria.Listar();
                this.Formato();
                this.Limpiar();
                LBLTotal.Text = "Total de Registros: " + Convert.ToString(DGVCategoria.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Buscar()
        {
            try
            {
                DGVCategoria.DataSource = NCategoria.Buscar(TXTBuscar.Text);
                LBLTotal.Text = "Total de Registros: " + Convert.ToString(DGVCategoria.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DGVCategoria.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVCategoria.ColumnHeadersDefaultCellStyle.Font = new Font(DGVCategoria.Font, FontStyle.Bold);
            DGVCategoria.EnableHeadersVisualStyles = false;
            DGVCategoria.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#39ff14");
            //DGVCategoria.AutoResizeColumns(); // para tamaño automatico de columna segùn tamaño de los datos importados de ORACLE
            //DGVCategoria.ColumnDefaultCellStyleChanged = DataGridViewColumnHeadersHeightSizeMode.AutoSize; solo para la cabezera
            DGVCategoria.Columns[0].Visible = false;
            DGVCategoria.Columns[1].Width = 70;
            DGVCategoria.Columns[1].HeaderText = "CÓDIGO";
            DGVCategoria.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVCategoria.Columns[2].Width = 200;
            DGVCategoria.Columns[2].HeaderText = "CATEGORÍA PRODUCTO";
            DGVCategoria.Columns[3].Width = 354;
            DGVCategoria.Columns[3].HeaderText = "DESCRIPCIÓN";
            DGVCategoria.Columns[4].Width = 80;
            DGVCategoria.Columns[4].HeaderText = "ESTADO";
            DGVCategoria.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Limpiar()
        {
            TXTBuscar.Clear();
            TXTCodigo.Clear();
            TXTCategoria.Clear();
            TXTDescripcion.Clear();
            BTNNuevo.Enabled = true;
            BTNActualizar.Enabled = false;
            ErrorIcono.Clear();
            DGVCategoria.Columns[0].Visible = false;
            BTNActivar.Visible = false;
            BTNDesactivar.Visible = false;
            BTNEliminar.Visible = false;
            CHKSeleccionar.Checked = false;
        }        
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void FRMCategoria_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.Formato();
        }
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void BTNListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TXTCategoria.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTCategoria, "Ingrese el valor");
                }
                else
                {
                    Rpta = NCategoria.Insertar(Convert.ToInt32(TXTCodigo.Text), TXTCategoria.Text.Trim(), TXTDescripcion.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se guardó de forma correcta el registro");
                        this.Limpiar();
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
        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            this.Listar();
            BTNNuevo.Enabled = false;
            TXTCodigo.Text = Convert.ToString((DGVCategoria.Rows.Count) + 1);
            TXTCategoria.Focus();
            TXTCodigo.Enabled = false;
            BTNNuevo.Enabled = false;
            BTNGuardar.Enabled = true;
        }
        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Listar();
            TabGeneral.SelectedIndex = 0;
        }
        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TXTCategoria.Text == string.Empty || TXTCodigo.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTCategoria, "Ingrese el valor");
                }
                else
                {
                    Rpta = NCategoria.Actualizar(Convert.ToInt32(TXTCodigo.Text), this.NombreAnt,TXTCategoria.Text.Trim(), TXTDescripcion.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOK("Se actualizó de forma correcta el registro");
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

        private void DGVCategoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void CKBSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKSeleccionar.Checked)
            {
                DGVCategoria.Columns[0].Visible = true;
                BTNActivar.Visible = true;
                BTNDesactivar.Visible = true;
                BTNEliminar.Visible = true;
            }
            else
            {
                DGVCategoria.Columns[0].Visible = false;
                BTNActivar.Visible = false;
                BTNDesactivar.Visible = false;
                BTNEliminar.Visible = false;
            }
        }

        private void DGVCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BTNNuevo.Enabled = false;
                BTNActualizar.Enabled = true;
                BTNGuardar.Visible = false;
                TXTCodigo.Text = Convert.ToString(DGVCategoria.CurrentRow.Cells["ID_CATEGORIA"].Value);
                NombreAnt = Convert.ToString(DGVCategoria.CurrentRow.Cells["CATEGORIA"].Value);
                TXTCategoria.Text = Convert.ToString(DGVCategoria.CurrentRow.Cells["CATEGORIA"].Value);
                TXTDescripcion.Text = Convert.ToString(DGVCategoria.CurrentRow.Cells["DESCRIPCION"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione desde la celda Categoria Producto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void DGVCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVCategoria.Columns["SELECCIONAR"].Index) ;
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DGVCategoria.Rows[e.RowIndex].Cells["SELECCIONAR"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void BTNEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta Seguro que desea eliminar el(los) registro(s)", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DGVCategoria.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Eliminar(Codigo);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTNActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta Seguro que desea Activar el(los) registro(s)", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DGVCategoria.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Activar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Activó el registro: " + Convert.ToString(row.Cells[2].Value));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BTNDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta Seguro que desea desactivar el(los) registro(s)", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DGVCategoria.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoria.Desactivar(Codigo);
                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se Desactivó el registro: " + Convert.ToString(row.Cells[2].Value));
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
