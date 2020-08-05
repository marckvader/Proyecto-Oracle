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
    public partial class FRM_Def_Monedas : Form
    {
        private string NombreAnt2;
        public FRM_Def_Monedas()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DGVListado.DataSource = NMonedas.Listar();
                this.Formato();
                //this.Limpiar();
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
            DGVListado.Columns[1].HeaderText = "CÓDIGO";
            DGVListado.Columns[2].Width = 70;
            DGVListado.Columns[2].HeaderText = "SIGLA";
            DGVListado.Columns[3].Width = 350;
            DGVListado.Columns[3].HeaderText = "DESCRIPCIÓN";
        }
        private void Limpiar()
        {
            TXTIdMoneda.Clear();
            TXTSeries.Clear();
            TXTDescripcion.Clear();
            BTNGuardar.Visible = true;
            BTNActualizar.Visible = false;
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
                DGVListado.DataSource = NMonedas.Buscar(TXTBuscar.Text);
                LblTotal.Text = "Total de Registros: " + Convert.ToString(DGVListado.Rows.Count);
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

        private void BTNListar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Def_Monedas_Load(object sender, EventArgs e)
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
            TXTIdMoneda.Text = Convert.ToString((DGVListado.Rows.Count) + 1);
            TXTSeries.Focus();
            TXTIdMoneda.Enabled = false;
            TXTIdMoneda.Enabled = false;
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
                if (TXTSeries.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTSeries, "Ingrese el valor");
                    ErrorIcono.SetError(TXTDescripcion, "Ingrese el valor");
                }
                else
                {
                    Rpta = NMonedas.Insertar(Convert.ToInt32(TXTIdMoneda.Text), TXTSeries.Text.Trim(),TXTDescripcion.Text.Trim());
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
                if (TXTSeries.Text == string.Empty || TXTDescripcion.Text == string.Empty)
                {
                    this.MensajeError("El estacio esta en blanco, por favor ingrese un dato valido, el campo sera remarcado");
                    ErrorIcono.SetError(TXTSeries, "Ingrese el valor");
                    ErrorIcono.SetError(TXTDescripcion, "Ingrese el valor");
                }
                else
                {
                    Rpta = NMonedas.Actualizar(Convert.ToInt32(TXTIdMoneda.Text), this.NombreAnt2, TXTSeries.Text.Trim(), TXTDescripcion.Text.Trim());
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
                BTNGuardar.Visible = false;
                TXTIdMoneda.Text = Convert.ToString(DGVListado.CurrentRow.Cells["ID_MONEDA"].Value);
                NombreAnt2 = Convert.ToString(DGVListado.CurrentRow.Cells["COD_MONEDA"].Value);
                TXTSeries.Text = Convert.ToString(DGVListado.CurrentRow.Cells["COD_MONEDA"].Value);
                TXTDescripcion.Text = Convert.ToString(DGVListado.CurrentRow.Cells["DESCRIPCION"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione desde la celda SIGLA", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
