using System;
namespace GuiaArreglos
{

    class Ejercicio2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio2: foreach");
            string[] frutas = { "Manzana", "Banana", "Naranja", "Pera" };
            Console.WriteLine("Frutas en el arreglo:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine("- " + fruta);
            }

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadLine();

        }
    }
}