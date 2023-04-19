using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria para hacer referencia a los formularios
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class Cola
    {
        //Estas variables con tipo de dato de la clase Nodo, son para hacer referencia a los objetos que se crean de la misma clase
        //Estas referencias o nombres para los objetos funcionan guardando la posicion de memoria de estos objetos
        public Nodo Primero;
        public Nodo Ultimo;


        //El argumento nuevo recibe los objetos creados de la clase Nodo, cada objeto creado de esta clase contiene una copia
        // de los atributos de la misma
        public void Agregar(Nodo Nuevo)
        {
            //Pregunto si esta referencia primero esta asignada a un objeto(nodo) // Si esta vacio
            if (Primero == null)
            {
                //Si no hay nodos, entonces el nodo(objeto) que recibio el agregar pasa a llamar Primero y Ultimo
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                //El ultimo, que como referencia es de un objeto, accede a su atributo Siguiente(que es una variable que tambien se usa
                // para referenciar) y le asigno al nuevo objeto que vino del argumento 
                Ultimo.Siguiente = Nuevo;
                //Como ya se "encadeno" mi nuevo objeto ahora lo paso a referenciar como el ultimo
                Ultimo = Nuevo;
            }

        }
        public void Eliminar()
        {
            //Si primero y ultimo referencian al mismo objeto
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                //Establezco que ahora el Primero va a hacer el que este en el atributo siguiente del mismo 
                Primero = Primero.Siguiente;
            }
        }


        
        public void Recorrer(DataGridView Grilla)
        {
            Nodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
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
                Combo.Items.Add(aux.Nombre);
                aux = aux.Siguiente;
            }
        }


    }
}
