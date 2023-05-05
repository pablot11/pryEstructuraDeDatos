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
    public partial class frmArbolBinario : Form
    {
        //Declaracion de objetos
        clsArbolBinario ObjArbolBinario = new clsArbolBinario();
        Nodo objNodo;
        public frmArbolBinario()
        {
            InitializeComponent();
        }

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
            ObjArbolBinario.Recorrer(tvMostrar);
        }

        private void optInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
        
            ObjArbolBinario.Recorrer(grlMostrar);
            ObjArbolBinario.Recorrer(lstMostrar);
            ObjArbolBinario.Recorrer(lstCodigo);
            ObjArbolBinario.Recorrer(tvMostrar);
        }

        private void optInOrdenDes_CheckedChanged(object sender, EventArgs e)
        {
            optInOrdenAsc.Enabled = true;
            ObjArbolBinario.RecorrerDes(grlMostrar);
            ObjArbolBinario.RecorrerDes(lstMostrar);
            ObjArbolBinario.RecorrerDes(lstCodigo);
            ObjArbolBinario.RecorrerDes(tvMostrar);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbolBinario.RecorrerPre(grlMostrar);
            ObjArbolBinario.RecorrerPre(lstMostrar);
            ObjArbolBinario.RecorrerPre(lstCodigo);
            ObjArbolBinario.RecorrerPre(tvMostrar);
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            ObjArbolBinario.RecorrerPost(grlMostrar);
            ObjArbolBinario.RecorrerPost(lstMostrar);
            ObjArbolBinario.RecorrerPost(lstCodigo);
            ObjArbolBinario.RecorrerPost(tvMostrar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {         
            int varCodigo = Convert.ToInt32(lstCodigo.Text);
            ObjArbolBinario.Eliminar(varCodigo);
            if (ObjArbolBinario.Raiz != null)
            {
                ObjArbolBinario.Recorrer(grlMostrar);
                ObjArbolBinario.Recorrer(lstMostrar);
                ObjArbolBinario.Recorrer(lstCodigo);
                ObjArbolBinario.Recorrer(tvMostrar);
            }
            else
            {
                grlMostrar.Rows.Clear();

            }

        }
    }
}

