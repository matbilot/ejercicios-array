using System;
namespace guiasArreglos
{
    class ejer3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 3: length y bucle for");
            int[] precios = { 100, 250, 300, 150, 80 };
            int cantidadElementos = precios.Length;

            Console.WriteLine("el arreglo tiene " + cantidadElementos + " elementos");
            Console.WriteLine("los elementos del arreglo son:");

            for (int i = 0; i < precios.Length; i++)
            {
                Console.WriteLine("indice " + i + ": el precio es " + precios[i]);
            }

            Console.WriteLine("fin del ejercicio 3");
            Console.ReadLine();
        }
    }
}