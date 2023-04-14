using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEstructuraDatos
{
    internal class clsPila
    {
        //Instanciamos como si fuera una variable
        public Nodo Primero;
        
        public void Agregar(Nodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
            }
            else
            {
                //Decimos que se enganche al "primero"
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }



        }
        public void Eliminar() {

            if (Primero != null)
            {
                //Como estan todos enganchados, el primero se elimina
                Primero = Primero.Siguiente;
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













    }
}
