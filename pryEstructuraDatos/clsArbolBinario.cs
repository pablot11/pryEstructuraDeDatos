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
        private Nodo Inicio;
        StreamWriter sw = new StreamWriter("Recorrer.csv", true);
        public Nodo Raiz
        {
            get {return Inicio;}
            set { Inicio = value; }
        }
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

        //-----------------------------Procedimientos Recorrer InOrdenAsc-----------------------------------//
        //-------------------------------------------------------------------------------------------------//

        //----------------------------InOrdenAsc ListBox-----------------------------------//
        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        public void InOrdenAsc(ListBox LstBox, Nodo R)
        {
            // Lo mismo pero mas extenso:
            //if (R.Izquierdo != null)
            //{
            //    InOrdenAsc(Lst, R.Izquierdo); // I
            //}
            //Lst.Items.Add(R.Codigo); // R
            //if (R.Derecho != null)
            //{
            //    InOrdenAsc(Lst, R.Derecho); // D
            //}

            //Forma mas eficiente de poner if:
            if (R.Izquierdo != null) InOrdenAsc(LstBox, R.Izquierdo); //I
            LstBox.Items.Add(R.Codigo + " " +  R.Nombre + " " + R.Tramite); //R
            if (R.Derecho != null) InOrdenAsc(LstBox, R.Derecho); //D

            //Mostrar solo lo que quiero saber
            //if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo); //I
            //if (R.Tramite == "Pagar")Lst.Items.Add(R.Codigo); //R
            //if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho); //D

        }//-----------------------------Fin OrdenAsc ListBox-------------------------------//

        //----------------------------InOrdenAsc Grilla-----------------------------------//
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

        }//----------------------------Fin InOrdenAsc Grilla-----------------------------//

        //----------------------------InOrdenAsc Combo-----------------------------------//
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


        }//----------------------------Fin InOrdenAsc Combo-----------------------------//

        //--------------------------------InOrdenAsc TreeView---------------------------//

        public void Recorrer(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            InOrdenAsc(TreeView, Raiz);
        }
        public void InOrdenAsc(TreeView TreeView, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(TreeView, R.Derecho);
            TreeView.Nodes.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenAsc(TreeView, R.Izquierdo);
        }//--------------------------------Fin InOrdenAsc TreeView----------------------//

        public void Recorrer(StreamWriter sw)
        {
            InOrdenAsc(sw, Raiz);
        }
        public void InOrdenAsc(StreamWriter sw, Nodo R)
        {
            if (R.Derecho != null) InOrdenAsc(sw, R.Derecho);
            sw.Write(R.Codigo);
            sw.Write(";");
            sw.Write(R.Nombre);
            sw.Write(";");
            sw.WriteLine(R.Tramite);
            if (R.Izquierdo != null) InOrdenAsc(sw, R.Izquierdo);
        }







        //-----------------------------Procedimientos Recorrer InOrdenDes-----------------------------------//
        //-------------------------------------------------------------------------------------------------//
        //----------------------------InOrdenDes ListBox-----------------------------------//
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

        }//-----------------------------Fin InOrdenDes ListBox-----------------------------//

        //----------------------------InOrdenDes Grilla-----------------------------------//
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
            if (R.Izquierdo!= null) InOrdenDes(dgvMostrar, R.Izquierdo); //I

        }//----------------------------Fin InOrdenAsc Grilla-----------------------------//



        //----------------------------InOrdenDes Grilla-----------------------------------//
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

        }//----------------------------Fin InOrdenAsc Grilla-----------------------------//
         //--------------------------------InOrdenDes TreeView---------------------------//

        public void RecorrerDes(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            InOrdenDes(TreeView, Raiz);
        }
        public void InOrdenDes(TreeView TreeView, Nodo R)
        {
            if (R.Derecho != null) InOrdenDes(TreeView, R.Derecho);
            TreeView.Nodes.Add(R.Codigo.ToString());
            if (R.Izquierdo != null) InOrdenDes(TreeView, R.Izquierdo);
        }//--------------------------------Fin InOrdenDes TreeView----------------------//

        //-----------------------------Procedimientos Recorrer PreOrden-----------------------------------//
        //-------------------------------------------------------------------------------------------------//
        //----------------------------------ListBox PreOrden---------------------------------//
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
        }//-----------------------------------Fin ListBox PreOrden-----------------------------//

        //----------------------------------DataGridView PreOrden---------------------------------//
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
        }//-----------------------------------Fin DataGridView PreOrden-----------------------------//

        //----------------------------------Combo PreOrden---------------------------------//
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
        }//-----------------------------------Fin Combo PreOrden-----------------------------//

        //--------------------------------PreOrden TreeView---------------------------//

        public void RecorrerPre(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            PreOrden(TreeView, Raiz);
        }
        public void PreOrden(TreeView TreeView, Nodo R)
        {
            TreeView.Nodes.Add(R.Codigo.ToString());
            if (R.Derecho != null) PreOrden(TreeView, R.Derecho);
            if (R.Izquierdo != null) PreOrden(TreeView, R.Izquierdo);
        }//--------------------------------Fin PreOrden TreeView----------------------/

        //-----------------------------Procedimientos Recorrer PostOrden-----------------------------------//
        //-------------------------------------------------------------------------------------------------//
        //----------------------------------ListBox PostOrden---------------------------------//
        public void RecorrerPost(ListBox lstBox)
        {
            lstBox.Items.Clear();
            PostOrden(lstBox, Raiz);
        }
        public void PostOrden(ListBox lstBox, Nodo R)
        {
            if (R.Izquierdo != null) PreOrden(lstBox, R.Izquierdo);
            if (R.Derecho != null) PreOrden(lstBox, R.Derecho);
            lstBox.Items.Add(R.Codigo + " " + R.Nombre + " " + R.Tramite);
        }//-----------------------------------Fin ListBox PostOrden-----------------------------//

        //----------------------------------DataGridView PostOrden---------------------------------//
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
        }//-----------------------------------Fin DataGridView PostOrden-----------------------------//

        //----------------------------------Combo PostOrden---------------------------------//
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
        }//-----------------------------------Fin Combo PostOrden-----------------------------//
        //--------------------------------PostOrden TreeView---------------------------//

        public void RecorrerPost(TreeView TreeView)
        {
            TreeView.Nodes.Clear();
            PostOrden(TreeView, Raiz);
        }
        public void PostOrden(TreeView TreeView, Nodo R)
        {
            TreeView.Nodes.Add(R.Codigo.ToString());
            if (R.Derecho != null) PostOrden(TreeView, R.Derecho);
            if (R.Izquierdo != null) PostOrden(TreeView, R.Izquierdo);
        }//--------------------------------Fin PostOrden TreeView----------------------/

        private Nodo[] vector = new Nodo[100];
        private Int32 i = 0;
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


    }
}
