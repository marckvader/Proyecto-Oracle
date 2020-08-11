using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria.Presentacion
{
    public partial class FRMPrincipal : Form
    {
        private int childFormNumber = 0;

        public FRMPrincipal()
        {
            InitializeComponent();
        }
        private void FRMPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void ProvinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMProvincias frm = new FRMProvincias();
            frm.MdiParent = this;
            frm.Show();
        }
        private void MantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void DefEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMTipo_Cia frm = new FRMTipo_Cia();
            frm.MdiParent = this;
            frm.Show();
        }
        private void CategoriasProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCategoria frm = new FRMCategoria();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Esta Seguro que desea salir de la aplicacion", "Sistema de Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Opcion == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FRMProvincias frm = new FRMProvincias();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FRMTipo_Cia frm = new FRMTipo_Cia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PrametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Def_Monedas frm = new FRM_Def_Monedas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void undMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Unds_Medidas frm = new FRM_Unds_Medidas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void EmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DATOS_EMPRESA frm = new FRM_DATOS_EMPRESA();
            frm.MdiParent = this;
            frm.Show();
        }

        private void TipoPersoneriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Tipo_Identificacion frm = new FRM_Tipo_Identificacion();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}