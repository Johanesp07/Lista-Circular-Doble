using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Examen_Johan_Espinoza_A_
{


    public class NodoDoble
    {
        public string Nombre { get; set; }
        public NodoDoble? Siguiente { get; set; }
        public NodoDoble? Anterior { get; set; }

        public NodoDoble(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;
            Anterior = null;
        }
    }
}
