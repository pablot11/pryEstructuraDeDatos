using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    public partial class frmArbolBinario : Form
    {
        //Declaracion de objetos
        clsArbolBinario ObjArbolBinario = new clsArbolBinario();
        Nodo objNodo;
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        //Botones


        private void btnAgregar_Click(object sender, EventArgs e)
        {

            objNodo = new Nodo();
            objNodo.Nombre = txtNombre.Text;
            objNodo.Tramite = txtTramite.Text;
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjArbolBinario.Agregar(objNodo);
            ObjArbolBinario.Recorrer(grlMostrar);
            ObjArbolBinario.Recorrer(lstMostrar);
            ObjArbolBinario.Recorrer(lstCodigo);
            optInOrden.Checked = true;
            optAsc.Checked = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                int varCodigo = Convert.ToInt32(lstCodigo.Text);
                ObjArbolBinario.Eliminar(varCodigo);
                ObjArbolBinario.Recorrer(grlMostrar);
                ObjArbolBinario.Recorrer(lstMostrar);
                ObjArbolBinario.Recorrer(lstCodigo);
            }
            else
            {
                grlMostrar.Rows.Clear();
                btnEliminar.Enabled = false;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (optAsc.Checked != true)
            {
                StreamWriter sw = new StreamWriter("Arbol.csv");
                if (optInOrden.Checked == true && optAsc.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwInOrdenAsc(sw);
                }
                else if (optInOrden.Checked == true && optDes.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwInOrdenDes(sw);
                }
                if (optPostOrden.Checked == true && optAsc.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwPreOrdenAsc(sw);
                }
                else if (optPostOrden.Checked == true && optDes.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwPostAsc(sw);
                }
                if (optPreOrden.Checked == true && optAsc.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwPreOrdenAsc(sw);
                }
                else if (optPreOrden.Checked == true && optDes.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwPreOrdenDes(sw);
                }
                sw.Dispose();
            }
            MessageBox.Show("Seleccione una forma de listar");

        }
        //----------------------------------------------------------------------------------------------------//

        //Botones de opcion InOrde,PreOrden,PostOrden
        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if(ObjArbolBinario.Raiz != null)
            {
                optAsc.Checked = true;
                optDes.Checked = false;
                ObjArbolBinario.RecorrerPre(grlMostrar);
                ObjArbolBinario.RecorrerPre(lstMostrar);
                ObjArbolBinario.RecorrerPre(lstCodigo);
            }
  
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                optAsc.Checked = true;
                optDes.Checked = false;
                ObjArbolBinario.RecorrerPost(grlMostrar);
                ObjArbolBinario.RecorrerPost(lstMostrar);
                ObjArbolBinario.RecorrerPost(lstCodigo);

            } 
        }


        private void optInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                optAsc.Checked = true;
                optDes.Checked = false;
                ObjArbolBinario.Recorrer(grlMostrar);
                ObjArbolBinario.Recorrer(lstMostrar);
                ObjArbolBinario.Recorrer(lstCodigo);

            }
           
        }
        //Botones de opcion Ascendente y descendente
        private void optDes_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                if (optInOrden.Checked == true)
                {
                    ObjArbolBinario.RecorrerDes(grlMostrar);
                    ObjArbolBinario.RecorrerDes(lstMostrar);
                    ObjArbolBinario.RecorrerDes(lstCodigo);

                }
                if (optPostOrden.Checked == true)
                {
                    ObjArbolBinario.RecorrerPostDes(grlMostrar); ObjArbolBinario.RecorrerPostDes(lstMostrar); ObjArbolBinario.RecorrerPostDes(lstCodigo);
                }
                if (optPreOrden.Checked == true)
                {
                    ObjArbolBinario.RecorrerPreDes(grlMostrar); ObjArbolBinario.RecorrerPreDes(lstMostrar); ObjArbolBinario.RecorrerPreDes(lstCodigo);
                }
            }          
           
        }

        private void optAsc_CheckedChanged(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                if (optInOrden.Checked == true)
                {
                    ObjArbolBinario.Recorrer(grlMostrar);
                    ObjArbolBinario.Recorrer(lstMostrar);
                    ObjArbolBinario.Recorrer(lstCodigo);


                }
                if (optPostOrden.Checked == true)
                {
                    ObjArbolBinario.RecorrerPost(grlMostrar); ObjArbolBinario.RecorrerPost(lstMostrar); ObjArbolBinario.RecorrerPost(lstCodigo);
                }
                if (optPreOrden.Checked == true)
                {
                    ObjArbolBinario.RecorrerPre(grlMostrar);
                    ObjArbolBinario.RecorrerPre(lstMostrar);
                    ObjArbolBinario.RecorrerPre(lstCodigo);
                    ObjArbolBinario.RecorrerPre(tvMostrar);
                }
            }
          
         
        }

  
    }
}

