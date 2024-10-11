namespace _1_Examen_Johan_Espinoza_A_
{
    using global::ListaCircularDobleApp;
    using System;

    namespace ListaCircularDobleApp
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                ListaCircularDoble lista = new ListaCircularDoble();

                // Insertar algunos nombres al inicio
                lista.InsertarInicio("Alice");
                lista.InsertarInicio("Bob");
                lista.InsertarInicio("Charlie");

                // Mostrar el contenido de la lista
                Console.WriteLine(lista.Mostrar());

                // Eliminar un nombre al final
                Console.WriteLine(lista.EliminarFinal());

                // Mostrar el contenido de la lista después de eliminar
                Console.WriteLine(lista.Mostrar());

                // Esperar a que el usuario presione una tecla para cerrar
                Console.ReadKey();
            }
        }
    }
}

