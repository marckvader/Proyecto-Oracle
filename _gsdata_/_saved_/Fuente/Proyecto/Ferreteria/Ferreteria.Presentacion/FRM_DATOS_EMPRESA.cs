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
                //this.Limpiar();
                //LblTotal.Text = "Total de Registros: " + Convert.ToString(DGVListado.Rows.Count);
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
            DGVListado.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListado.Columns[1].Width = 100;
            DGVListado.Columns[2].Width = 100;
            DGVListado.Columns[3].Width = 130;
            DGVListado.Columns[4].Width = 420;
            DGVListado.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListado.Columns[5].Width = 151;
        }

        /*LLENADO DE LOS COMBOBOX*/
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
        
        private void FRM_DATOS_EMPRESA_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarCMBProvincias();
            this.CargarCMBTipoEmpresa();
            this.CargarCMBTipoID();
            TXTCodigo.Focus();
        }
        private void TSBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*FORMATO PARA LA SECUENCIA DEL LLENADO DE LOS DOCUMENTOS*/
        private void TSBNuevo_Click(object sender, EventArgs e)
        {
            TXTCodigo.BackColor = Color.LightBlue;
            TabGeneral.SelectedIndex = 1;
            TXTCodigo.Focus();
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
