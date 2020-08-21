using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Ferreteria.Negocio;

namespace Ferreteria.Presentacion
{
    public partial class FRM_DATOS_EMPRESA : Form
    {
        private string AntNumID;
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
                
               // TXTEmail.Text = datosimp.Rows[0][2].ToString();
                //TXTDireccion.Text = Convert.ToString(datosimp.DataSet["PERSONERIA"]);
                //LBLTotal.Text = "Total de Registros: " + Convert.ToString(DGVCategoria.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ListarDetallado()
        {
            DataTable DatosImp = new DataTable();
            DatosImp = NEmpresa.ListarDetallado();

            TXTCodigo.Text = DatosImp.Rows[0][0].ToString();
            /*this.CargarCMBTipoEmpresa();
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
            TXTEmail.Clear();*/


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
            CHKSeleccionar.Checked = false;
        }
        private void Buscar()
        {
            try
            {
                DGVListado.DataSource = NEmpresa.Buscar(TXTBuscar.Text);
                //LBLTotal.Text = "Total de Registros: " + Convert.ToString(DGVCategoria.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /********************* LOGICA DE CRUD EN LOS CONTROLES *********************/
        /********************* INICIO BOTONES DEL MENU *****************************/
        private void BTNBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        private void TSBBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
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
        private void TSBActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TXTRazonSocial.Text == string.Empty || TXTIdentificacion.Text == string.Empty || TXTCodigo.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTCodigo, "Ingrese el Valor");
                    ErrorIcono.SetError(TXTRazonSocial, "Ingrese el Valor");
                    ErrorIcono.SetError(TXTIdentificacion, "Ingrese el Valor");
                }
                else
                {
                    Rpta = NEmpresa.Actualizar(Convert.ToInt32(TXTCodigo.Text), Convert.ToInt32(CMBTipoEmpresa.SelectedValue), Convert.ToInt32(CMBTipoID.SelectedValue), TXTIdentificacion.Text.Trim(), AntNumID,TXTRazonSocial.Text.Trim(), TXTNombre.Text.Trim(), Convert.ToInt32(CMBProvincia.SelectedValue), TXTDireccion.Text.Trim(), MTXTTelefono1.Text.Trim(), MTXTTelefono2.Text.Trim(), MTXTFax.Text.Trim(), TXTCp.Text.Trim(), TXTWeb.Text.Trim(), TXTEmail.Text.Trim());
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
        private void TSBEliminar_Click(object sender, EventArgs e)
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
                            Rpta = NEmpresa.Eliminar(Codigo);
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
        private void TSBActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta Seguro que desea Activar el(los) registro(s)", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DGVListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NEmpresa.Activar(Codigo);
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

        private void TSBDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta Seguro que desea desactivar el(los) registro(s)", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Opcion == DialogResult.Yes)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in DGVListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NEmpresa.Desactivar(Codigo);
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
        /******************** FIN BOTONES DEL MENU ********************/
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
        private void DGVListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                TSBNuevo.Enabled = false;
                TSBActualizar.Enabled = true;
                //TSBGuardar.Visible = false;
                TXTCodigo.Text = Convert.ToString(DGVListado.CurrentRow.Cells["CÓDIGO"].Value);
                CMBTipoEmpresa.Text = Convert.ToString(DGVListado.CurrentRow.Cells["PERSONERIA"].Value);
                TXTIdentificacion.Text = Convert.ToString(DGVListado.CurrentRow.Cells["Nº IDENTIFICACION"].Value);
                AntNumID = Convert.ToString(DGVListado.CurrentRow.Cells["Nº IDENTIFICACION"].Value);
                TXTRazonSocial.Text = Convert.ToString(DGVListado.CurrentRow.Cells["RAZÓN SOCIAL"].Value);
                CMBTipoEmpresa.Text = Convert.ToString(DGVListado.CurrentRow.Cells["TIPO DE COMPAÑIA"].Value);
                TabGeneral.SelectedIndex = 1;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione desde la celda Categoria Producto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /******************** FORMATO DE LOS CONTROLES  ********************/

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
            this.ListarDetallado();
            this.CargarCMBProvincias();
            this.CargarCMBTipoEmpresa();
            this.CargarCMBTipoID();
            TXTCodigo.Focus();
            TXTBuscar.Focus();
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

        private void TXTBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}