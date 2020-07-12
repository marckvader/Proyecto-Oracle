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
        private void provinciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMProvincias frm = new FRMProvincias();
            frm.MdiParent = this;
            frm.Show();
        }
        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void defEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMTipo_Cia frm = new FRMTipo_Cia();
            frm.MdiParent = this;
            frm.Show();
        }
        private void categoriasProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMCategoria frm = new FRMCategoria();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}