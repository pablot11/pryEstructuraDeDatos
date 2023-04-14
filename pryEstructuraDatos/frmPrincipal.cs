using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datosProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosPersonales objVentanaDatosPersonles = new frmDatosPersonales();
            objVentanaDatosPersonles.Show();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola ObjCola = new frmCola();
            ObjCola.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPila objVentana = new frmPila();
            objVentana.ShowDialog();    
        }
    }
}
