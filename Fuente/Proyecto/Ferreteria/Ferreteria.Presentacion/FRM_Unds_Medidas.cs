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
    public partial class FRM_Unds_Medidas : Form
    {
        private string NombreAnt2;
        public FRM_Unds_Medidas()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DGVListado.DataSource = NUnds_Medidas.Listar();
                this.Formato();
                this.Limpiar();
                LBLTotal.Text = "Total de Registros: " + Convert.ToString(DGVListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DGVListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListado.ColumnHeadersDefaultCellStyle.Font = new Font(DGVListado.Font, FontStyle.Bold);
            DGVListado.EnableHeadersVisualStyles = false;
            DGVListado.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#39ff14");
            DGVListado.Columns[0].Visible = false;
            DGVListado.Columns[1].Width = 100;
            DGVListado.Columns[1].HeaderText = "ID";
            DGVListado.Columns[2].Width = 70;
            DGVListado.Columns[2].HeaderText = "CÓDIGO";
            DGVListado.Columns[3].Width = 350;
            DGVListado.Columns[3].HeaderText = "DESCRIPCIÓN";
        }
        private void Limpiar()
        {
            TXTCodigo.Clear();
            TXTSigla.Clear();
            TXTDescripcion.Clear();
            BTNGuardar.Visible = true;
            BTNActualizar.Visible = true;
            ErrorIcono.Clear();
            DGVListado.Columns[0].Visible = false;
            DGVListado.Columns[1].Visible = true;
            BTNEliminar.Visible = false;
            CHKSeleccionar.Checked = false;
        }
        private void Buscar()
        {
            try
            {
                DGVListado.DataSource = NUnds_Medidas.Buscar(TXTBuscar.Text);
                LBLTotal.Text = "Total de Registros: " + Convert.ToString(DGVListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FRM_Unds_Medidas_Load(object sender, EventArgs e)
        {
            BTNActivar.Visible = false;
            BTNDesactivar.Visible = false;
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void TXTCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNActualizar.Enabled = true;
            BTNEliminar.Enabled = true;
            this.Buscar();
        }

        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            this.Listar();
            TXTCodigo.Text = Convert.ToString((DGVListado.Rows.Count) + 1);
            TXTSigla.Focus();
            BTNActivar.Enabled = false;
            TXTCodigo.Enabled = false;
            TXTSigla.Enabled = true;
            BTNNuevo.Enabled = false;
            BTNGuardar.Enabled = true;
            BTNActualizar.Enabled = false;
        }

        private void BTNGuardar_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = true;
            BTNGuardar.Enabled = false;
            BTNBuscar.Enabled = true;
            BTNActualizar.Enabled = false;
            try
            {
                string Rpta = "";
                if (TXTSigla.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTSigla, "Ingrese el valor");
                    ErrorIcono.SetError(TXTDescripcion, "Ingrese el valor");
                }
                else
                {
                    Rpta = NUnds_Medidas.Insertar(Convert.ToInt32(TXTCodigo.Text), TXTSigla.Text.Trim(), TXTDescripcion.Text.Trim());
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

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TXTSigla.Text == string.Empty || TXTDescripcion.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTSigla, "Ingrese el valor");
                    ErrorIcono.SetError(TXTDescripcion, "Ingrese el valor");
                }
                else
                {
                    Rpta = NUnds_Medidas.Actualizar(Convert.ToInt32(TXTCodigo.Text), this.NombreAnt2, TXTSigla.Text.Trim(), TXTDescripcion.Text.Trim());
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
        private void DGVListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BTNNuevo.Enabled = false;
                BTNActualizar.Enabled = true;
                BTNGuardar.Enabled = false;
                TXTCodigo.Text = Convert.ToString(DGVListado.CurrentRow.Cells["ID_UND_MEDIDA"].Value);
                NombreAnt2 = Convert.ToString(DGVListado.CurrentRow.Cells["COD_MEDIDA"].Value);
                TXTSigla.Text = Convert.ToString(DGVListado.CurrentRow.Cells["COD_MEDIDA"].Value);
                TXTDescripcion.Text = Convert.ToString(DGVListado.CurrentRow.Cells["DESCRIPCION"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione desde la celda SIGLA", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        

        private void DGVListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListado.Columns["SELECCIONAR"].Index) ;
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
                Opcion = MessageBox.Show("Esta Seguro que desea eliminar el(los) registro(s)", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DGVListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NUnds_Medidas.Eliminar(Codigo);
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

        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Listar();
            TabGeneral.SelectedIndex = 0;
            BTNNuevo.Enabled = true;
            BTNActualizar.Enabled = true;
        }

        private void CHKSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKSeleccionar.Checked)
            {
                DGVListado.Columns[0].Visible = true;
                BTNActivar.Visible = true;
                BTNDesactivar.Visible = true;
                BTNEliminar.Visible = true;
            }
            else
            {
                DGVListado.Columns[0].Visible = false;
                BTNActivar.Visible = false;
                BTNDesactivar.Visible = false;
                BTNEliminar.Visible = false;
            }
        }

        private void DGVListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListado.Columns["SELECCIONAR"].Index) ;
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DGVListado.Rows[e.RowIndex].Cells["SELECCIONAR"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }
    }
}

