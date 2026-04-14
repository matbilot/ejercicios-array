using System;
namespace guiasArreglos
{
    class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 3: length y bucle for");
            int[] años = { 2000, 2005, 2010, 2015, 2020 };
            int cantidadElementos = años.Length;

            Console.WriteLine("el arreglo tiene " + cantidadElementos + " elementos");
            Console.WriteLine("los elementos del arreglo son:");

            for (int i = 0; i < años.Length; i++)
            {
                Console.WriteLine("indice " + i + ": el año es " + años[i]);
            }

            Console.WriteLine("fin del ejercicio 3");
            Console.ReadLine();
        }
    }
}