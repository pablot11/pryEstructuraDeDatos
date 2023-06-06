using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void simpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListaSimple objVentana = new frmListaSimple();
                objVentana.ShowDialog();
        }

        private void dobleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListaDoble objListaDoble = new frmListaDoble();
            objListaDoble.ShowDialog();
        }

        private void arbolBinarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbolBinario obJArbolBinario = new frmArbolBinario();
            obJArbolBinario.ShowDialog();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void consultaEnLaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaBaseDatos objBD = new frmConsultaBaseDatos();
            objBD.ShowDialog();
        }

        private void operacionesConTablasDeBasesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseDatos objBD = new frmBaseDatos();
            objBD.ShowDialog();
        }

        private void repasoDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarPorOperaciones obj = new frmConsultarPorOperaciones();
            obj.ShowDialog();
        }
    }
}
