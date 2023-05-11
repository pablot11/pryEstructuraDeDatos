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

        //Eventos de programador
        private void HabilitarBotonAgregar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }
        private void LimpiarControles()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }
        private void ValidarSoloLetras(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }

        }

        //Fin eventos del programador

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
            LimpiarControles();
            txtCodigo.Focus();
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
                btnEliminar.Enabled = false;

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

        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
            btnEliminar.Enabled = false;
        }


        //Textboxs de el apartado de agregar

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonAgregar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonAgregar();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            HabilitarBotonAgregar();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(sender, e);
        }

        private void txtTramite_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(sender, e);
        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
        }
    }
}
