using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        clsListaDoble objListaDoble = new clsListaDoble();
        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Nodo objNodo = new Nodo();
            objNodo.Nombre = txtNombre.Text;
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Tramite = txtTramite.Text;
            objListaDoble.Agregar(objNodo);
       
                
                    objListaDoble.Recorrer(grlMostrar);
                    objListaDoble.Recorrer(lstCodigo);
                    objListaDoble.Recorrer(lstMostrar);

              


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objListaDoble.Primero != null)
            {
                Int32 varCodigo = 0;
                varCodigo = Convert.ToInt32(lstCodigo.Text);
                objListaDoble.Eliminar(varCodigo);
                objListaDoble.Recorrer(grlMostrar);
                objListaDoble.Recorrer(lstCodigo);
                objListaDoble.Recorrer(lstMostrar);

            }
        }

        private void optAscendente_CheckedChanged(object sender, EventArgs e)
        {
            objListaDoble.Recorrer(grlMostrar);
            objListaDoble.Recorrer(lstCodigo);
            objListaDoble.Recorrer(lstMostrar);
        }

        private void optDescendente_CheckedChanged(object sender, EventArgs e)
        {
            objListaDoble.RecorrerDes(grlMostrar);
            objListaDoble.RecorrerDes(lstCodigo);
            objListaDoble.RecorrerDes(lstMostrar);
        }
    }
}
