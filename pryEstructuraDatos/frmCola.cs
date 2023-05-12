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
    
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        //Creacion del objeto de la clase Cola
        Cola FilaDePersonas = new Cola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {



            Nodo ObjNodo = new Nodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(grlMostrar);
            FilaDePersonas.Recorrer(lstMostrar);
            LimpiarControles();
            txtCodigo.Focus();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {
                txtCodigoEliminar.Text = FilaDePersonas.Primero.Codigo.ToString();
                txtNombreEliminar.Text = FilaDePersonas.Primero.Nombre;
                txtTramiteEliminar.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(grlMostrar);
                FilaDePersonas.Recorrer(lstMostrar);
                btnEliminar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Esta vacio, por favor agregue un dato", "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                
                
            }
        }
        private void frmCola_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            txtCodigo.Focus();
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
        //Procedimientos del programador
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


    }
}
