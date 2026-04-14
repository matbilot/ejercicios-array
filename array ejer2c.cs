using System;
namespace GuiaArreglos
{

     static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio2: foreach");
        string[] animales = { "Perro", "Gato", "Caballo", "Conejo" };

        Console.WriteLine("Animales en el arreglo:");
        foreach (string animal in animales)
        {
            Console.WriteLine("- " + animal);
        }

        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadLine();
    }
}