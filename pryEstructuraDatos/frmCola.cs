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
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersonas.Primero != null)
            {

                lblCodigo.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblNombre.Text = FilaDePersonas.Primero.Nombre;
                lblTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(grlMostrar);
                FilaDePersonas.Recorrer(lstMostrar);
                

            }
            else
            {
                
                
                    lblCodigo.Text = "";
                    lblNombre.Text = "";
                    lblTramite.Text = "";
                
            }


        }
    }
}
