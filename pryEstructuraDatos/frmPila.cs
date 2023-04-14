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
    
    public partial class frmPila : Form
    {

        Nodo objNodo;
        clsPila objPila = new clsPila();



        public frmPila()
        {
            InitializeComponent();
        }
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objNodo = new Nodo();
            objNodo.Nombre = txtNombre.Text;
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Tramite = txtTramite.Text;
            objPila.Agregar(objNodo);
            objPila.Recorrer(grlMostrar);



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {

                lblCodigo.Text = objPila.Primero.Codigo.ToString();
                lblNombre.Text = objPila.Primero.Nombre;
                lblTramite.Text = objPila.Primero.Tramite;
                objPila.Eliminar();
                objPila.Recorrer(grlMostrar);
                objPila.Recorrer(lstMostrar);


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
