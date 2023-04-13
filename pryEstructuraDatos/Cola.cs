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
        //Crear el nodo con el nombre de la clase
        public Nodo Primero;
        public Nodo Ultimo;

        public void Agregar(Nodo Nuevo)
            //  Pregunto si no hay ningun registro
            //Que el nuevo tome ambos valores
        {
            if (Primero == null)
            {
                //El primero y el ultimo pasan a ser el nuevo
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                //esta linea hace que se enganche con el nuevo
                Ultimo.Siguiente = Nuevo;
                //Se establece que es el ultimo el nuevo
                Ultimo = Nuevo;
            }

        }
        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
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
