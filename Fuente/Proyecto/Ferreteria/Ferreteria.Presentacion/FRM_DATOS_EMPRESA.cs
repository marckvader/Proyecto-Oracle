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
    public partial class FRM_DATOS_EMPRESA : Form
    {
        public FRM_DATOS_EMPRESA()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                DGVListado.DataSource = NEmpresa.Listar();
                this.Formato();
                this.Limpiar();
                //LBLTotal.Text = "Total de Registros: " + Convert.ToString(DGVCategoria.Rows.Count);
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
            DGVListado.Columns[1].Width = 70;           
            DGVListado.Columns[2].Width = 120;            
            DGVListado.Columns[3].Width = 130;            
            DGVListado.Columns[4].Width = 350;
            DGVListado.Columns[5].Width = 130;
            DGVListado.Columns[6].Width = 100;
        }
        private void Limpiar()
        {
            TXTCodigo.Clear();
            this.CargarCMBTipoEmpresa();
            this.CargarCMBTipoID();
            TXTIdentificacion.Clear();
            TXTRazonSocial.Clear();
            TXTNombre.Clear();
            this.CargarCMBProvincias();
            TXTDireccion.Clear();
            MTXTTelefono1.Clear();
            MTXTTelefono2.Clear();
            MTXTFax.Clear();
            TXTCp.Clear();
            TXTWeb.Clear();
            TXTEmail.Clear();                               
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /*********** LOGICA DE CRUD EN LOS CONTROLES ***********/
        private void TSBGuardar_Click(object sender, EventArgs e)
        {
            TSBNuevo.Enabled = true;
            TSBGuardar.Enabled = false;
            TSBBuscar.Enabled = true;
            TSBActualizar.Enabled = false;
            try
            {
                string Rpta = "";
                if (TXTCodigo.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTCodigo, "Ingrese el valor");
                    ErrorIcono.SetError(TXTNombre, "Ingrese el valor");
                    ErrorIcono.SetError(TXTRazonSocial, "Ingrese el valor");
                }
                else
                {
                    Rpta = NEmpresa.Insertar(Convert.ToInt32(TXTCodigo.Text), Convert.ToInt32(CMBTipoEmpresa.SelectedValue), Convert.ToInt32(CMBTipoID.SelectedValue), TXTIdentificacion.Text.Trim(), TXTRazonSocial.Text.Trim(), TXTNombre.Text.Trim(), Convert.ToInt32(CMBProvincia.SelectedValue), TXTDireccion.Text.Trim(), MTXTTelefono1.Text.Trim(), MTXTTelefono2.Text.Trim(), MTXTFax.Text.Trim(), TXTCp.Text.Trim(), TXTWeb.Text.Trim(), TXTEmail.Text.Trim());
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
        private void CHKSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CHKSeleccionar.Checked)
            {
                DGVListado.Columns[0].Visible = true;
                TSBActivar.Enabled = true;
                TSBDesactivar.Enabled = true;
                TSBEliminar.Enabled = true;
            }
            else
            {
                DGVListado.Columns[0].Visible = false;
                TSBActivar.Enabled = false;
                TSBDesactivar.Enabled = false;
                TSBEliminar.Enabled = false;
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
        private void DGVListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                TSBNuevo.Enabled = false;
                TSBActualizar.Enabled = true;
                TSBGuardar.Visible = false;

                TXTCodigo.Text = Convert.ToString(DGVListado.CurrentRow.Cells["CÓDIGO"].Value);
                CargarCMBTipoEmpresa. = Convert.ToString(DGVListado.CurrentRow.Cells["PERSONERIA"].Value);
                TXTCategoria.Text = Convert.ToString(DGVListado.CurrentRow.Cells["Nº IDENTIFICACION"].Value);
                TXTDescripcion.Text = Convert.ToString(DGVListado.CurrentRow.Cells["RAZÓN SOCIAL"].Value);
                TXTDescripcion.Text = Convert.ToString(DGVListado.CurrentRow.Cells["TIPO DE COMPAÑIA"].Value);
                TXTCodigo.Clear();
                /*this.CargarCMBTipoEmpresa();
                this.CargarCMBTipoID();
                .Clear();
                TXTRazonSocial.Clear();
                TXTNombre.Clear();
                this.CargarCMBProvincias();
                TXTDireccion.Clear();
                MTXTTelefono1.Clear();
                MTXTTelefono2.Clear();
                MTXTFax.Clear();
                TXTCp.Clear();
                TXTWeb.Clear();
                TXTEmail.Clear();
                TabGeneral.SelectedIndex = 1;*/
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione desde la celda Categoria Producto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /********** FORMATO DE LOS CONTROLES  **********/

        private void CargarCMBProvincias()
        {
            CMBProvincia.DataSource = NProvincias.Listar();
            CMBProvincia.ValueMember = "ID_provincia";
            CMBProvincia.DisplayMember = "Provincia";
        }
        private void CargarCMBTipoEmpresa()
        {
            CMBTipoEmpresa.DataSource = NTipoCia.Listar();
            CMBTipoEmpresa.ValueMember = "ID_Tipo_Cia";
            CMBTipoEmpresa.DisplayMember = "Tipo_Empresa";
        }
        private void CargarCMBTipoID()
        {
            CMBTipoID.DataSource = NTipo_Identificacion.Listar();
            CMBTipoID.ValueMember = "ID_Tipo_Identificacion";
            CMBTipoID.DisplayMember = "Personeria";
        }
        private void TSBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FRM_DATOS_EMPRESA_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCMBProvincias();
            this.CargarCMBTipoEmpresa();
            this.CargarCMBTipoID();
            TXTCodigo.Focus();
        }
        private void TSBNuevo_Click(object sender, EventArgs e)
        {
            TXTCodigo.BackColor = Color.LightBlue;
            TabGeneral.SelectedIndex = 1;
            TXTCodigo.Text = Convert.ToString(DGVListado.Rows.Count+1);
            TXTCodigo.Enabled = false;
            CMBTipoEmpresa.Focus();
        }

        private void TXTCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXTCodigo.BackColor = Color.White;
                CMBTipoEmpresa.Focus();
                CMBTipoEmpresa.BackColor = Color.LightBlue;
            }
        }
        private void CMBTipoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CMBTipoEmpresa.BackColor = Color.White;
                CMBTipoID.Focus();
                CMBTipoID.BackColor = Color.LightBlue;
            }
        }
        private void CMBTipoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CMBTipoID.BackColor = Color.White;
                TXTIdentificacion.Focus();
                TXTIdentificacion.BackColor = Color.LightBlue;
            }
        }

        private void TXTIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXTIdentificacion.BackColor = Color.White;
                TXTRazonSocial.Focus();
                TXTRazonSocial.BackColor = Color.LightBlue;
            }
        }
        private void TXTRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXTRazonSocial.BackColor = Color.White;
                TXTNombre.Focus();
                TXTNombre.BackColor = Color.LightBlue;
            }
        }
        private void TXTNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXTNombre.BackColor = Color.White;
                CMBProvincia.Focus();
                CMBProvincia.BackColor = Color.LightBlue;
            }
        }
        private void CMBProvincia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                CMBProvincia.BackColor = Color.White;
                TXTDireccion.Focus();
                TXTDireccion.BackColor = Color.LightBlue;
            }
        }

        private void TXTDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXTDireccion.BackColor = Color.White;
                MTXTTelefono1.Focus();
                MTXTTelefono1.BackColor = Color.LightBlue;
            }
        }
        private void MTXTTelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MTXTTelefono1.BackColor = Color.White;
                MTXTTelefono2.Focus();
                MTXTTelefono2.BackColor = Color.LightBlue;
            }
        }

        private void MTXTTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MTXTTelefono2.BackColor = Color.White;
                MTXTFax.Focus();
                MTXTFax.BackColor = Color.LightBlue;
            }
        }
        private void MTXTFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MTXTFax.BackColor = Color.White;
                TXTCp.Focus();
                TXTCp.BackColor = Color.LightBlue;
            }
        }

        private void TXTCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXTCp.BackColor = Color.White;
                TXTWeb.Focus();
                TXTWeb.BackColor = Color.LightBlue;
            }
        }

        private void TXTWeb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TXTWeb.BackColor = Color.White;
                TXTEmail.Focus();
                TXTEmail.BackColor = Color.LightBlue;
            }
        }       
    }
}



