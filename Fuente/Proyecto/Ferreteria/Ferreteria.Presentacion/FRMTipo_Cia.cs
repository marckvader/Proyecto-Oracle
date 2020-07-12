using System;
using System.Windows.Forms;
using Ferreteria.Negocio;

namespace Ferreteria.Presentacion
{
    public partial class FRMTipo_Cia : Form
    {
        private string NombreAnterior;
        public FRMTipo_Cia()
        {
            InitializeComponent();
        }
        private void Inicializar()
        {
            BTNEliminar.Visible = false;
            BTNNuevo.Enabled=true;
            BTNActualizar.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNCancelar.Enabled = true;
        }
        private void Listar()
        {
            try
            {
                DGVLTipoEmpresa.DataSource = NTipoCia.Listar();
                this.Formato();
                this.Limpiar();
                LblTotal.Text = "Total de Registros: " + Convert.ToString(DGVLTipoEmpresa.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Formato()
        {
            DGVLTipoEmpresa.Columns[0].Visible = false;
            DGVLTipoEmpresa.Columns[1].Width = 100;
            DGVLTipoEmpresa.Columns[1].HeaderText = "CODIGO";
            DGVLTipoEmpresa.Columns[2].Width = 141;
            DGVLTipoEmpresa.Columns[2].HeaderText = "TIPO EMPRESA";
            DGVLTipoEmpresa.Columns[3].Width = 141;
            DGVLTipoEmpresa.Columns[3].HeaderText = "DESCRIPCION";
        }
        private void Limpiar()
        {
            TXTCodEmpresa.Clear();
            TXTTipoEmpresa.Clear();
            TXTDescripcion.Clear();
            BTNGuardar.Visible = true;
            BTNActualizar.Enabled = false;
            ErrorIcono.Clear();
            DGVLTipoEmpresa.Columns[0].Visible = false;
            DGVLTipoEmpresa.Columns[1].Visible = true;
            DGVLTipoEmpresa.Columns[2].Visible = true;
            DGVLTipoEmpresa.Columns[3].Visible = true;
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
                DGVLTipoEmpresa.DataSource = NTipoCia.Buscar(TXTBuscar.Text);
                this.Formato();
                LblTotal.Text = "Total de Registros: " + Convert.ToString(DGVLTipoEmpresa.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
       
        private void BTNListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            this.Listar();
            TXTCodEmpresa.Text = Convert.ToString((DGVLTipoEmpresa.Rows.Count) + 1);
            TXTCodEmpresa.Focus();
            TXTCodEmpresa.Enabled = false;
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
                if (TXTTipoEmpresa.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTTipoEmpresa, "Ingrese el valor");
                    ErrorIcono.SetError(TXTDescripcion, "ingrese el valor");
                }
                else
                {
                    Rpta = NTipoCia.Insertar(Convert.ToInt32(TXTCodEmpresa.Text), TXTTipoEmpresa.Text.Trim(), TXTDescripcion.Text.Trim());
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
        private void FRMTipo_Cia_Load(object sender, EventArgs e)
        {
            this.Inicializar();
        }
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            BTNNuevo.Enabled = false;
            BTNGuardar.Enabled = false;
            BTNActualizar.Enabled = true;
            BTNEliminar.Enabled = true;
            this.Buscar();
            TXTBuscar.Text = "";
        }
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CHKSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKSeleccionar.Checked)
            {
                DGVLTipoEmpresa.Columns[0].Visible = true;
                BTNEliminar.Visible = true;
            }
            else
            {
                DGVLTipoEmpresa.Columns[0].Visible = false;
                BTNEliminar.Visible = false;
            }
        }
        private void DGVLTipoEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BTNNuevo.Enabled = false;
                BTNActualizar.Visible = true;
                BTNActualizar.Enabled = true;
                BTNGuardar.Enabled = false;
                TXTCodEmpresa.Text = Convert.ToString(DGVLTipoEmpresa.CurrentRow.Cells["ID_Tipo_Cia"].Value);
                this.NombreAnterior = Convert.ToString(DGVLTipoEmpresa.CurrentRow.Cells["Tipo_Empresa"].Value);
                TXTTipoEmpresa.Text = Convert.ToString(DGVLTipoEmpresa.CurrentRow.Cells["Tipo_Empresa"].Value);
                TXTDescripcion.Text = Convert.ToString(DGVLTipoEmpresa.CurrentRow.Cells["Descripcion"].Value);
                TABGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleciones desde la celda Codigo", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BTNActualizar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string Rpta = "";
                    if (TXTCodEmpresa.Text == string.Empty || TXTTipoEmpresa.Text == string.Empty || TXTDescripcion.Text == string.Empty)
                    {
                        this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                        ErrorIcono.SetError(TXTCodEmpresa, "Ingrese el valor");
                        ErrorIcono.SetError(TXTTipoEmpresa, "Ingrese el valor");
                        ErrorIcono.SetError(TXTDescripcion, "Ingrese el valor");
                    }
                    else
                    {
                        Rpta = NTipoCia.Actualizar(Convert.ToInt32(TXTCodEmpresa.Text), this.NombreAnterior, TXTTipoEmpresa.Text.Trim(), TXTDescripcion.Text.Trim()); ;
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
        }

        private void DGVLTipoEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVLTipoEmpresa.Columns["SELECCIONAR"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DGVLTipoEmpresa.Rows[e.RowIndex].Cells["SELECCIONAR"];
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
                    foreach (DataGridViewRow row in DGVLTipoEmpresa.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NTipoCia.Eliminar(Codigo);
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
            this.Inicializar();
            TABGeneral.SelectedIndex = 0;
        }
    }
}
