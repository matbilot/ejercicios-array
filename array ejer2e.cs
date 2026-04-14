using System;
namespace GuiaArreglos
{

    static void Main(string[] args)
    {
        Console.WriteLine("Ejercicio2: foreach");
        string[] verduras = { "Lechuga", "Tomate", "Zanahoria", "Papa" };

        Console.WriteLine("Verduras en el arreglo:");
        foreach (string verdura in verduras)
        {
            Console.WriteLine("- " + verdura);
        }

        Console.WriteLine("Presiona cualquier tecla para continuar...");
        Console.ReadLine();
    }

}