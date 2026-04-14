using System;
namespace guiasArreglos
{
    class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 3: length y bucle for");
            int[] edades = { 20, 25, 30, 35, 40 };
            int cantidadElementos = edades.Length;
            Console.WriteLine(" el arrego tiene " + cantidadElementos + " elementos");
            Console.WriteLine(" los elementos del arreglo son: ");

            for (int i = 0; i < edades.Length; i++)
            {
                Console.WriteLine("indice" + i + ": la edad es " + edades[i]);
            }
            Console.WriteLine(" fin del ejercicio 3");
            Console.ReadLine();
        }
    }
    
}