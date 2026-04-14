using System;
namespace GuiaArreglos
{

    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio2: foreach");
        string[] paises = { "Argentina", "Brasil", "Chile", "Uruguay" };

        Console.WriteLine("Países en el arreglo:");
        foreach (string pais in paises)
        {
            Console.WriteLine("- " + pais);
        }

        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadLine();
    }
}