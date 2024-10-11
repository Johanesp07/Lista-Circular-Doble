using _1_Examen_Johan_Espinoza_A_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaCircularDobleApp
{
    public class ListaCircularDoble
    {
        private NodoDoble? primero;
        private NodoDoble? ultimo;

        public ListaCircularDoble()
        {
            primero = null;
            ultimo = null;
        }

        // Método para insertar un nodo al inicio
        public void InsertarInicio(string nombre)
        {
            NodoDoble nuevoNodo = new NodoDoble(nombre);
            if (primero == null)
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
                primero.Siguiente = primero;
                primero.Anterior = ultimo;
            }
            else
            {
                nuevoNodo.Siguiente = primero;
                nuevoNodo.Anterior = ultimo;
                primero.Anterior = nuevoNodo;
                ultimo.Siguiente = nuevoNodo;
                primero = nuevoNodo;
            }
        }

        // Método para eliminar un nodo al final
        public string EliminarFinal()
        {
            if (ultimo == null)
            {
                return "La lista está vacía.";
            }

            string nombreEliminado = ultimo.Nombre;
            if (primero == ultimo)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                ultimo = ultimo.Anterior;
                ultimo.Siguiente = primero;
                primero.Anterior = ultimo;
            }
            return $"Nodo con nombre '{nombreEliminado}' eliminado del final.";
        }

        // Método para mostrar el contenido de la lista
        public string Mostrar()
        {
            if (primero == null)
            {
                return "La lista está vacía.";
            }

            NodoDoble actual = primero;
            string resultado = "Contenido de la lista: ";
            do
            {
                resultado += actual.Nombre + " <-> ";
                actual = actual.Siguiente;
            } while (actual != primero);

            return resultado.TrimEnd(' ', '<', '-', '>') + " (de vuelta al inicio)";
        }
    }
}
