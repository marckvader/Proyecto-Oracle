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
            this.CargarCMBProvincias();
            this.CargarCMBTipoEmpresa();
            this.CargarCMBTipoID();
            TXTCodigo.Focus();
        }
        private void TSBNuevo_Click(object sender, EventArgs e)
        {
            TXTCodigo.BackColor = Color.LightBlue;
            TabGeneral.SelectedIndex = 1;
            TXTCodigo.Focus();
        }

        private void TXTCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                TXTCodigo.BackColor = Color.White;
                CMBTipoEmpresa.Focus();
                CMBTipoEmpresa.BackColor = Color.LightBlue;
            }
        }
        private void CMBTipoEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                CMBTipoEmpresa.BackColor = Color.White;
                CMBTipoEmpresa.Focus();
                CMBTipoID.BackColor = Color.LightBlue;
            }

        }
    }
}
