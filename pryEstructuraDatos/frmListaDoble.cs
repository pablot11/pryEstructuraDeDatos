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
            if (optAscendente.Checked == true || optDescendente.Checked == true)
            {
                if (optAscendente.Checked == true)
                {
                    objListaDoble.Recorrer(grlMostrar);
                    objListaDoble.Recorrer(lstCodigo);
                    objListaDoble.Recorrer(lstMostrar);

                }
                else if (optDescendente.Checked == true)
                {
                    objListaDoble.RecorrerDes(grlMostrar);
                    objListaDoble.RecorrerDes(lstCodigo);
                    objListaDoble.RecorrerDes(lstMostrar);
                }
            }
            else
            {
                MessageBox.Show("Elegir si ascendete o descendente");
                this.Close();
            }


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
    }
}
