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
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;

            Lista.Agregar(objNodo);
            Lista.Recorrer(grlMostrar);
            Lista.Recorrer(lstCodigo);
            Lista.Recorrer(lstMostrar);
            LimpiarControles();
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
                btnEliminar.Enabled = true;
                if (Lista.Primero != null)
                {
                    Int32 varCodigo = 0;
                    varCodigo = Convert.ToInt32(lstCodigo.Text);
                    Lista.Eliminar(varCodigo);
                    Lista.Recorrer(grlMostrar);
                    Lista.Recorrer(lstCodigo);
                    Lista.Recorrer(lstMostrar);

                }
                else
                {
                    MessageBox.Show("Esta vacio, por favor agregue un dato", "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                }
            btnEliminar.Enabled = false;

            

          


        }

        private void frmListaSimple_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
            btnEliminar.Enabled = false;
        }

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
        //Keypress
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

        //Fin keypress

    }
}
