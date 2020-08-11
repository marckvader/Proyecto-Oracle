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
    public partial class FRM_Tipo_Identificacion : Form
    {
        public FRM_Tipo_Identificacion()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DGVListado.DataSource = NTipo_Identificacion.Listar();
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
            DGVListado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGVListado.ColumnHeadersDefaultCellStyle.Font = new Font(DGVListado.Font, FontStyle.Bold);
            DGVListado.EnableHeadersVisualStyles = false;
            DGVListado.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#39ff14");
            DGVListado.Columns[0].Visible = false;
            DGVListado.Columns[1].Width = 100;
            DGVListado.Columns[1].HeaderText = "CODIGO";
            DGVListado.Columns[2].Width = 228;
            DGVListado.Columns[2].HeaderText = "TIPO IDENTIFICACION";
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
        private void BTNListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void FRM_Tipo_Identificacion_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
