using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryEstructuraDatos
{
    internal class Cola
    {

        public Nodo Primero;
        public Nodo Ultimo;

        public void Agregar(Nodo Nuevo)
            //  Pregunto si no hay ningun registro
            //Que el nuevo tome ambos valores
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }

        }



    }
}
