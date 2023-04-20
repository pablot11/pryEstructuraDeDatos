using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmListaSimple : Form
    {
        clsListaSimple Lista = new clsListaSimple();


        public frmListaSimple()
        {
            InitializeComponent();
        }

        private void mrcElementoEliminado_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo objNodo = new Nodo();
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(grlMostrar);
            Lista.Recorrer(lstCodigo);
            Lista.Recorrer(lstMostrar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 varCodigo = 0;
                varCodigo = Convert.ToInt32(lstCodigo.Text);
                Lista.Eliminar(varCodigo);
                Lista.Recorrer(grlMostrar);
                Lista.Recorrer(lstCodigo);
                Lista.Recorrer(lstMostrar);

            }
 
            




        }
    }
}
