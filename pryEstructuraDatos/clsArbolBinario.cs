using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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















    }
}
