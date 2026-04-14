using System;
namespace guiasArreglos
{
    class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 3: length y bucle for");
            int[] notas = { 6, 7, 8, 9, 10 };
            int cantidadElementos = notas.Length;

            Console.WriteLine("el arreglo tiene " + cantidadElementos + " elementos");
            Console.WriteLine("los elementos del arreglo son:");

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("indice " + i + ": la nota es " + notas[i]);
            }

            Console.WriteLine("fin del ejercicio 3");
            Console.ReadLine();
        }
    }
}