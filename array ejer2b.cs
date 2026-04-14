using System;
namespace GuiaArreglos
{

    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio2: foreach");
        string[] nombres = { "Juan", "María", "Lucas", "Sofía" };

        Console.WriteLine("Nombres en el arreglo:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine("- " + nombre);
        }

        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadLine();
    }
}