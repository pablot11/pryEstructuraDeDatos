using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsListaDoble
    {
        private Nodo pri;
        private Nodo ult;
        public Nodo Primero
        {
            get { return pri; }
            set { pri = value; }

        }
        public Nodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(Nodo Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;


            }
            else
            {
                //Si queremos que se carguen repetido ponemos menor o igual
                if (Nvo.Codigo <= Primero.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;


                }
                else
                {
                    if (Nvo.Codigo >= Ultimo.Codigo)
                    {

                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;


                    }
                    else
                    {
                        Nodo Aux = Primero;
                        Nodo Ant = Primero;
                        while (Aux.Codigo <= Nvo.Codigo)
                        {
                            Ant = Aux;
                            Ant = Aux.Siguiente;




                        }
                        Ant.Siguiente = Nvo;
                        Nvo.Siguiente = Aux;
                        Aux.Anterior = Nvo;
                        Nvo.Anterior = Ant;


                    }
                   


                }


            }



        }
        public void Recorrer(DataGridView grlMostrar)
        {
            Nodo aux = Primero;
            grlMostrar.Rows.Clear();
            while (aux != null)
            {
                grlMostrar.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }

        }
        public void Recorrer(ListBox Lista)
        {
            Nodo aux = Primero;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Siguiente;

            }




        }
        public void Recorrer(ComboBox Combo)
        {
            Nodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Siguiente;
            }
        }
        //Recorrido al reves

        public void RecorrerDes(DataGridView grlMostrar)
        {
            Nodo aux = Ultimo;
            grlMostrar.Rows.Clear();
            while (aux != null)
            {
                grlMostrar.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }

        }
        public void RecorrerDes(ListBox Lista)
        {
            Nodo aux = Ultimo;
            Lista.Items.Clear();
            while (aux != null)
            {
                Lista.Items.Add(aux.Codigo + " " + aux.Nombre + " " + aux.Tramite);
                aux = aux.Anterior;

            }




        }
        public void RecorrerDes(ComboBox Combo)
        {
            Nodo aux = Ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.Codigo);
                aux = aux.Anterior;
            }
        }

        //Eliminar
        public void Eliminar(Int32 Codigo)
        {
            //Primer if si el dato que borro es el unico de la lista
            if (Primero.Codigo == Codigo && Ultimo == Primero)
            {

                Primero = null;
                Ultimo = null;



            }
            else
            {
                if (Primero.Codigo == Codigo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.Codigo == Codigo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        Nodo aux = Primero;
                        Nodo ant = Primero;
                        while (aux.Codigo != Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;


                        }
                        
                        aux = aux.Siguiente;
                        ant.Siguiente = aux;
                        aux.Anterior = ant;


                        // Diferente forma
                        //ant.Siguiente = aux.Siguiente;
                        //aux = aux.Siguiente;
                        //aux.Anterior = ant;
                    }



                }
            }
        
        
        }




    }
}
