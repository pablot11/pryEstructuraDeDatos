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

        //Procedimientos desarrollador
        public void LimpiarBotones()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigo.Focus();

        }
        public void LimpiarOpt()
        {
            optAsc.Checked = false;
            optDes.Checked = false;
            optInOrden.Checked = false;
            optPostOrden.Checked = false;
            optPreOrden.Checked = false;

        }
        public void HabilitarAgregar()
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
            ObjArbolBinario.Recorrer(tvMostrar);
            optInOrden.Checked = true;
            optAsc.Checked = true;
            LimpiarBotones();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
                btnEliminar.Enabled = false;
                btnBuscar.Enabled = false;
                int varCodigo = Convert.ToInt32(lstCodigo.Text);
                ObjArbolBinario.Eliminar(varCodigo);
                if (ObjArbolBinario.Raiz != null)
                {
                    ObjArbolBinario.Recorrer(grlMostrar);
                    ObjArbolBinario.Recorrer(lstMostrar);
                    ObjArbolBinario.Recorrer(lstCodigo);
                }
                else
                {
                    grlMostrar.Rows.Clear();
                    lstCodigo.Items.Clear();
                    lstCodigo.SelectedIndex = -1;
                    LimpiarBotones();
                    LimpiarOpt();
                    

                }


        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
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
                    ObjArbolBinario.RecorrerSwPostAsc(sw);
                }
                else if (optPostOrden.Checked == true && optDes.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwPostDes(sw);
                }
                if (optPreOrden.Checked == true && optAsc.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwPreOrdenAsc(sw);
                }
                else if (optPreOrden.Checked == true && optDes.Checked == true)
                {
                    ObjArbolBinario.RecorrerSwPreOrdenDes(sw);
                }
                sw.Close();
                sw.Dispose();
            }
            else
            {
                MessageBox.Show("Seleccione una forma de listar");
                LimpiarOpt();
            }
           

        }
        //----------------------------------------------------------------------------------------------------//

        //`Procedimientos click





        private void optInOrden_Click(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                optAsc.Checked = false;
                optDes.Checked = false;

                //ObjArbolBinario.Recorrer(grlMostrar);
                //ObjArbolBinario.Recorrer(lstMostrar);
                //ObjArbolBinario.Recorrer(lstCodigo);
                //ObjArbolBinario.Recorrer(tvMostrar);

            }
        }

        private void optPostOrden_Click(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                optAsc.Checked = false;
                optDes.Checked = false;

                //ObjArbolBinario.Recorrer(grlMostrar);
                //ObjArbolBinario.Recorrer(lstMostrar);
                //ObjArbolBinario.Recorrer(lstCodigo);
                //ObjArbolBinario.Recorrer(tvMostrar);

            }



        }

        private void optPreOrden_Click(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                optAsc.Checked = false;
                optDes.Checked = false;

                //ObjArbolBinario.Recorrer(grlMostrar);
                //ObjArbolBinario.Recorrer(lstMostrar);
                //ObjArbolBinario.Recorrer(lstCodigo);
                //ObjArbolBinario.Recorrer(tvMostrar);

            }
        }

        private void optAsc_Click(object sender, EventArgs e)
        {
            if (ObjArbolBinario.Raiz != null)
            {
                if (optInOrden.Checked == true)
                {
                    ObjArbolBinario.Recorrer(grlMostrar);
                    ObjArbolBinario.Recorrer(lstMostrar);
                    ObjArbolBinario.Recorrer(lstCodigo);
                    ObjArbolBinario.Recorrer(tvMostrar);
                  


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

        private void optDes_Click(object sender, EventArgs e)
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
                    ObjArbolBinario.RecorrerPreDes(grlMostrar); ObjArbolBinario.RecorrerPreDes(lstMostrar); ObjArbolBinario.RecorrerPreDes(lstCodigo); ObjArbolBinario.RecorrerPreDes(tvMostrar);
                }

            }

        }
        //----------------------TextChanged Controles---------------------------------------//
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            HabilitarAgregar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            HabilitarAgregar();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            HabilitarAgregar();
        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCodigo.SelectedIndex != -1 && lstCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
                btnBuscar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnBuscar.Enabled=false;
            }
        }
        //----------------------------Keypress-----------------------//

        //Load formulario
        private void frmArbolBinario_Load(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloNumeros(sender, e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarSoloLetras(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarOpt();
            btnBuscar.Enabled = false;
            int varCodigo = Convert.ToInt32(lstCodigo.Text);
            grlMostrar.Rows.Clear();
            lstMostrar.Items.Clear();
            tvMostrar.Nodes.Clear();
            ObjArbolBinario.Buscar(varCodigo, grlMostrar, lstMostrar);
            
        }
    }
}

