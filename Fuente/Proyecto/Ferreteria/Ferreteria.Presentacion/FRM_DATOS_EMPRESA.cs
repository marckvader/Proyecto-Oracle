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
    public partial class FRM_DATOS_EMPRESA : Form
    {
        public FRM_DATOS_EMPRESA()
        {
            InitializeComponent();
        }   

        private void TSBSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
