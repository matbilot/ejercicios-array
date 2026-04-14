using System;
namespace guiasArreglos
{
    class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 3: length y bucle for");
            int[] temperaturas = { 18, 22, 25, 19, 21 };
            int cantidadElementos = temperaturas.Length;

            Console.WriteLine("el arreglo tiene " + cantidadElementos + " elementos");
            Console.WriteLine("los elementos del arreglo son:");

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine("indice " + i + ": la temperatura es " + temperaturas[i]);
            }

            Console.WriteLine("fin del ejercicio 3");
            Console.ReadLine();
        }
    }
}