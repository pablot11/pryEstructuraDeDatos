using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsArbolBinario
    {

        private Nodo Inicio;


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
                    if (Nvo.Codigo != Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }

                }
                //Afuera del while
                if (Nvo.Codigo != NodoPadre.Codigo)
                {
                    NodoPadre.Izquierdo = Nvo;
                }
                else
                {
                    NodoPadre.Derecho = Nvo;
                }

              

            }

        }


        public void Recorrer(ListBox Lista)
        {

            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);


        }
        public void InOrdenAsc(ListBox Lst, Nodo R)
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
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo); //I
            Lst.Items.Add(R.Codigo); //R
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho); //D

            //Mostrar solo lo que quiero saber
            //if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo); //I
            //if (R.Tramite == "Pagar")Lst.Items.Add(R.Codigo); //R
            //if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho); //D

        }
        public void InOrdenAsc(DataGridView dgvMostrar, Nodo R)
        {
            //Forma mas eficiente de poner if:
            if (R.Izquierdo != null) InOrdenAsc(dgvMostrar, R.Izquierdo); //I
            dgvMostrar.Rows.Add(R.Codigo); //R
            if (R.Derecho != null) InOrdenAsc(dgvMostrar, R.Derecho); //D

        }
        public void InOrdenAsc(ComboBox listadesplegable, Nodo R)
        {



        }


    }
}
