using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {
        //Declaracion de campos
        private Nodo[] vector = new Nodo[100];
        private Int32 i = 0;
        private Nodo Inicio;
        //Constructor clase
        public Nodo Raiz
        {
            get {return Inicio;}
            set { Inicio = value; }
        }

        //Procedimientos
        public void Agregar(Nodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                Nodo NodoPadre = Raiz; //ant
                Nodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Codigo <= Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }
                //Afuera del while
                if (Nvo.Codigo <= NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }
            }
        }
        public void Equilibrar()
        {
            i = 0;
            CargarVectorInOrden(Raiz);

            Raiz = null;
     
            EquilibrarArbol(0, i - 1);

        }
        private void CargarVectorInOrden(Nodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorInOrden(NodoPadre.Izquierdo);
            }
            vector[i] = NodoPadre;
            i++;
            if (NodoPadre.Derecho != null)
            {
                CargarVectorInOrden(NodoPadre.Derecho);
            }





        }
        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini<=fin)
            {
                Agregar(vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }



        }
        public void Eliminar(int Codigo)
        {
            Nodo NodoPadre = Raiz;
            i = 0;
            CargarVectorEliminar(NodoPadre, Codigo);
            Raiz = null;
            if (i>0) EquilibrarArbol(0, i - 1);
        }
        public void CargarVectorEliminar(Nodo NodoPadre, int Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                CargarVectorEliminar(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Codigo != Codigo)
            {
                vector[i] = NodoPadre;
                i++;
            }
            if (NodoPadre.Derecho != null)
            {
                CargarVectorEliminar(NodoPadre.Derecho, Codigo);
            }

        }

        public void Buscar(int Codigo, DataGridView dgv, ListBox ListBox)
        {
            BuscarNodo(Raiz, Codigo, dgv, ListBox) ;
        }
        public void BuscarNodo(Nodo R, int Codigo, DataGridView dgv, ListBox ListBox)
        {
            if (R.Izquierdo != null)
            {
                BuscarNodo(R.Izquierdo, Codigo, dgv, ListBox);          
            }
            if (R.Codigo == Codigo)
            {
                dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
                ListBox.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
     
            }
            if (R.Derecho != null)
            {
                 BuscarNodo(R.Derecho, Codigo, dgv, ListBox);
            }
                

        }

        //-------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------ListBox---------------------------------------------------------//
        //-------------------------------------------------------------------------------------------------------------------------//


        //---------------------------------------InOrdenAsc--------------------------------------//
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ListBox LstBox, Nodo R)
        {
            //Forma mas eficiente de poner if:
            if (R.Izquierdo != null) InOrdenAsc(LstBox, R.Izquierdo); //I
            LstBox.Items.Add(R.Codigo + " " +  R.Nombre + " " + R.Tramite); //R
            if (R.Derecho != null) InOrdenAsc(LstBox, R.Derecho); //D

            //Mostrar solo lo que quiero saber
            //if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo); //I
            //if (R.Tramite == "Pagar")Lst.Items.Add(R.Codigo); //R
            //if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho); //D

        }
        //---------------------------------------InOrdenDes-------------------------------------//
        public void RecorrerDes(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenDes(Lista, Raiz);
        }
        public void InOrdenDes(ListBox Lista, Nodo R)
        {
            if (R.Derecho != null) InOrdenDes(Lista, R.Derecho);
            Lista.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) InOrdenDes(Lista, R.Izquierdo);

        }

        //---------------------------------------PostOrdenAsc-------------------------------------//
        public void RecorrerPost(ListBox lstBox)
        {
            lstBox.Items.Clear();
            PostOrden(lstBox, Raiz);
        }
        public void PostOrden(ListBox lstBox, Nodo R)
        {
            if (R.Izquierdo != null) PostOrden(lstBox, R.Izquierdo);
            if (R.Derecho != null) PostOrden(lstBox, R.Derecho);
            lstBox.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }

        //---------------------------------------PostOrdenDes-------------------------------------//

        public void RecorrerPostDes(ListBox lstBox)
        {
            lstBox.Items.Clear();
            PostOrdenDes(lstBox, Raiz);
        }
        public void PostOrdenDes(ListBox lstBox, Nodo R)
        {
            if (R.Derecho != null) PostOrdenDes(lstBox, R.Derecho);
            if (R.Izquierdo != null) PostOrdenDes(lstBox, R.Izquierdo);
            lstBox.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }

        //---------------------------------------PreOrdenAsc-------------------------------------//
        public void RecorrerPre(ListBox lstBox)
        {
            lstBox.Items.Clear();
            PreOrden(lstBox, Raiz);
        }
        public void PreOrden(ListBox lstBox, Nodo R)
        {
            lstBox.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Izquierdo != null) PreOrden(lstBox, R.Izquierdo);
            if (R.Derecho != null) PreOrden(lstBox, R.Derecho);
        }

        //---------------------------------------PreOrdenDes-------------------------------------//
        public void RecorrerPreDes(ListBox lstBox)
        {
            lstBox.Items.Clear();
            PreOrdenDes(lstBox, Raiz);
        }
        public void PreOrdenDes(ListBox lstBox, Nodo R)
        {
            lstBox.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
            if (R.Derecho != null) PreOrdenDes(lstBox, R.Derecho);
            if (R.Izquierdo != null) PreOrdenDes(lstBox, R.Izquierdo);
        }

        //-------------------------------------------------------------------------------------------------------------------------//
        //--------------------------------------------------------Grilla---------------------------------------------------------//
        //-------------------------------------------------------------------------------------------------------------------------//

        //---------------------------------------InOrdenAsc--------------------------------------//
        public void Recorrer(DataGridView dgvMostrar)
        {
            dgvMostrar.Rows.Clear();
            InOrdenAsc(dgvMostrar, Raiz);
        }
        public void InOrdenAsc(DataGridView dgvMostrar, Nodo R)
        {
            //Forma mas eficiente de poner if:
            if (R.Izquierdo != null) InOrdenAsc(dgvMostrar, R.Izquierdo); //I
            dgvMostrar.Rows.Add(R.Codigo, R.Nombre, R.Tramite); //R
            if (R.Derecho != null) InOrdenAsc(dgvMostrar, R.Derecho); //D

        }

        //---------------------------------------InOrdenDes-------------------------------------//
        public void RecorrerDes(DataGridView dgvMostrar)
        {
            dgvMostrar.Rows.Clear();
            InOrdenDes(dgvMostrar, Raiz);
        }
        public void InOrdenDes(DataGridView dgvMostrar, Nodo R)
        {
            //Forma mas eficiente de poner if:
            if (R.Derecho != null) InOrdenDes(dgvMostrar, R.Derecho); //D
            dgvMostrar.Rows.Add(R.Codigo, R.Nombre, R.Tramite); //R
            if (R.Izquierdo != null) InOrdenDes(dgvMostrar, R.Izquierdo); //I

        }

        //---------------------------------------PostOrdenAsc-------------------------------------//
        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        public void PostOrden(DataGridView Grilla, Nodo R)
        {
            if (R.Izquierdo != null) PreOrden(Grilla, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Grilla, R.Derecho);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }

        //---------------------------------------PostOrdenDes-------------------------------------//

        public void RecorrerPostDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrdenDes(Grilla, Raiz);
        }
        public void PostOrdenDes(DataGridView Grilla, Nodo R)
        {
            if (R.Derecho != null) PostOrdenDes(Grilla, R.Derecho);
            if (R.Izquierdo != null) PostOrdenDes(Grilla, R.Izquierdo);
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
        }


        //---------------------------------------PreOrdenAsc-------------------------------------//

        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        public void PreOrden(DataGridView Grilla, Nodo R)
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Izquierdo != null) PreOrden(Grilla, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Grilla, R.Derecho);
        }

        //---------------------------------------PreOrdenDes-------------------------------------//

        public void RecorrerPreDes(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrdenDes(Grilla, Raiz);
        }
        public void PreOrdenDes(DataGridView Grilla, Nodo R)
        {
            Grilla.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) PreOrdenDes(Grilla, R.Derecho);
            if (R.Izquierdo != null) PreOrdenDes(Grilla, R.Izquierdo);
        }



        //-------------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------Combo---------------------------------------------------------//
        //-------------------------------------------------------------------------------------------------------------------------//

        //---------------------------------------InOrden----------------------------------------//
        public void Recorrer(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenAsc(Combo, Raiz);
        }

        public void InOrdenAsc(ComboBox Combo, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Combo, R.Izquierdo); //I
            Combo.Items.Add(R.Codigo); //R
            if (R.Derecho != null) InOrdenAsc(Combo, R.Derecho); //D


        }

        //---------------------------------------InOrdenDes-------------------------------------//
        public void RecorrerDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            InOrdenDes(Combo, Raiz);
        }
        public void InOrdenDes(ComboBox Combo, Nodo R)
        {
            //Forma mas eficiente de poner if:
            if (R.Derecho != null) InOrdenDes(Combo, R.Derecho); //I
            Combo.Items.Add(R.Codigo); //R
            if (R.Izquierdo != null) InOrdenDes(Combo, R.Izquierdo); //D

        }

        //---------------------------------------PostOrdenAsc-------------------------------------//
        public void RecorrerPost(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrden(Combo, Raiz);
        }
        public void PostOrden(ComboBox Combo, Nodo R)
        {
            if (R.Izquierdo != null) PostOrden(Combo, R.Izquierdo);
            if (R.Derecho != null) PostOrden(Combo, R.Derecho);
            Combo.Items.Add(R.Codigo);
        }

        //---------------------------------------PostOrdenDes -------------------------------------//

        public void RecorrerPostDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            PostOrdenDes(Combo, Raiz);
        }
        public void PostOrdenDes(ComboBox Combo, Nodo R)
        {
            if (R.Derecho != null) PostOrdenDes(Combo, R.Derecho);
            if (R.Izquierdo != null) PostOrdenDes(Combo, R.Izquierdo);
            Combo.Items.Add(R.Codigo);
        }


        //---------------------------------------PreOrdenAsc-------------------------------------//
        public void RecorrerPre(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrden(Combo, Raiz);
        }
        public void PreOrden(ComboBox Combo, Nodo R)
        {
            Combo.Items.Add(R.Codigo);
            if (R.Izquierdo != null) PreOrden(Combo, R.Izquierdo);
            if (R.Derecho != null) PreOrden(Combo, R.Derecho);

        }

        //---------------------------------------PreOrdenDes-------------------------------------//

        public void RecorrerPreDes(ComboBox Combo)
        {
            Combo.Items.Clear();
            PreOrdenDes(Combo, Raiz);
        }
        public void PreOrdenDes(ComboBox Combo, Nodo R)
        {
            Combo.Items.Add(R.Codigo);
            if (R.Derecho != null) PreOrdenDes(Combo, R.Derecho);
            if (R.Izquierdo != null) PreOrdenDes(Combo, R.Izquierdo);

        }


        //-------------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------TreeView---------------------------------------------------------//
        //-------------------------------------------------------------------------------------------------------------------------//


        //---------------------------------------InOrdenAsc -----------------------------------//

        public void Recorrer(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            InOrdenAsc(TreeView.Nodes, Raiz);
        }
        public void InOrdenAsc(TreeNodeCollection NodoPadre, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(NodoPadre, R.Derecho);
            TreeNode NuevoNodoTv = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(NuevoNodoTv.Nodes, R.Izquierdo);
        }





        //---------------------------------------InOrdenDes-------------------------------------//


        //---------------------------------------PostOrdenAsc-------------------------------------//

        //---------------------------------------PostOrdenDes-------------------------------------//

        //---------------------------------------PreOrdenAsc-------------------------------------//

        public void RecorrerPre(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            PreOrden(TreeView.Nodes, Raiz);
        }
        public void PreOrden(TreeNodeCollection NodoPadre, Nodo R)
        {
            TreeNode NuevoNodoTv = NodoPadre.Add(R.Codigo.ToString());
            if (R.Derecho != null) PreOrden(NuevoNodoTv.Nodes, R.Derecho);
            if (R.Izquierdo != null) PreOrden(NuevoNodoTv.Nodes, R.Izquierdo);
        }

        //---------------------------------------PreOrdenDes-------------------------------------//
        public void RecorrerPreDes(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            PreOrdenDes(TreeView.Nodes, Raiz);
        }
        public void PreOrdenDes(TreeNodeCollection NodoPadre, Nodo R)
        {
            TreeNode NuevoNodoTv = NodoPadre.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) PreOrdenDes(NuevoNodoTv.Nodes, R.Izquierdo);
            if (R.Derecho != null) PreOrdenDes(NuevoNodoTv.Nodes, R.Derecho);
        }

        //-------------------------------------------------------------------------------------------------------------------------//
        //-----------------------------------------------------------Archivo---------------------------------------------------------//
        //-------------------------------------------------------------------------------------------------------------------------//

        //---------------------------------------InOrdenAsc -----------------------------------//
        public void RecorrerSwInOrdenAsc(StreamWriter sw)
        {
            InOrdenAscArchivo(sw, Raiz);
        }


        public void InOrdenAscArchivo(StreamWriter NomArchi, Nodo R)
        {
            if (R.Izquierdo != null) InOrdenAscArchivo(NomArchi, R.Izquierdo);
            NomArchi.Write(R.Codigo);
            NomArchi.Write(" ; " + " ");
            NomArchi.Write(R.Nombre);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Tramite);
            NomArchi.Write("\n");
            if (R.Derecho != null) InOrdenAscArchivo(NomArchi, R.Derecho);


        }


        //---------------------------------------InOrdenDes-------------------------------------//

        public void RecorrerSwInOrdenDes(StreamWriter sw)
        {
            InOrdenDesArchivo(sw, Raiz);
        }


        public void InOrdenDesArchivo(StreamWriter NomArchi, Nodo R)
        {
            if (R.Derecho != null) InOrdenDesArchivo(NomArchi, R.Derecho);
            NomArchi.Write(R.Codigo);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Nombre);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Tramite);
            NomArchi.Write("\n");
            if (R.Izquierdo != null) InOrdenDesArchivo(NomArchi, R.Izquierdo);


        }



        //---------------------------------------PostOrdenAsc-------------------------------------//

        public void RecorrerSwPostAsc(StreamWriter sw)
        {
            PostOrdenAscArchivo(sw, Raiz);
        }


        public void PostOrdenAscArchivo(StreamWriter NomArchi, Nodo R)
        {
            if (R.Derecho != null) PostOrdenAscArchivo(NomArchi, R.Derecho);
            if (R.Izquierdo != null) PostOrdenAscArchivo(NomArchi, R.Izquierdo);
            NomArchi.Write(R.Codigo);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Nombre);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Tramite);
            NomArchi.Write("\n");
        }




        //---------------------------------------PostOrdenDes-------------------------------------//

        public void RecorrerSwPostDes(StreamWriter sw)
        {
            PostOrdenDesArchivo(sw, Raiz);
        }


        public void PostOrdenDesArchivo(StreamWriter NomArchi, Nodo R)
        {
            if (R.Izquierdo != null) PostOrdenDesArchivo(NomArchi, R.Izquierdo);
            if (R.Derecho != null) PostOrdenDesArchivo(NomArchi, R.Derecho);
            NomArchi.Write(R.Codigo);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Nombre);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Tramite);
            NomArchi.Write("\n");
        }



        //---------------------------------------PreOrdenAsc-------------------------------------//
        public void RecorrerSwPreOrdenAsc(StreamWriter sw)
        {
            PreOrdenAscArchivo(sw, Raiz);
        }
        public void PreOrdenAscArchivo(StreamWriter NomArchi, Nodo R)
        {
            NomArchi.Write(R.Codigo);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Nombre);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Tramite);
            NomArchi.Write("\n");
            if (R.Izquierdo != null) PreOrdenAscArchivo(NomArchi, R.Izquierdo);
            if (R.Derecho != null) PreOrdenAscArchivo(NomArchi, R.Derecho);
        }



        //---------------------------------------PreOrdenDes-------------------------------------//


        public void RecorrerSwPreOrdenDes(StreamWriter sw)
        {
            PreOrdenDesArchivo(sw, Raiz);
        }
        public void PreOrdenDesArchivo(StreamWriter NomArchi, Nodo R)
        {
            NomArchi.Write(R.Codigo);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Nombre);
            NomArchi.Write(" ; ");
            NomArchi.Write(R.Tramite);
            NomArchi.Write("\n");
            if (R.Izquierdo != null) PreOrdenDesArchivo(NomArchi, R.Izquierdo);
            if (R.Derecho != null) PreOrdenDesArchivo(NomArchi, R.Derecho);
        }


    }
}
