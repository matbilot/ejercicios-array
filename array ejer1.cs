using System;
namespace GuiaArreglos
{
  class Ejercicio01
  {
    static void Main(string[] args)
    {
        Console.WriteLine("ejer 1: fundamentos de arreglo");
        int[] numeros = new int[3];
        numeros[0] = 5;
        numeros[1] = 15;
        numeros[2] = 25;

        Console.WriteLine("valor en indice 0: " + numeros[0]);
        Console.WriteLine("valor en indice 1: " + numeros[1]);
        Console.WriteLine("valor en indice 2: " + numeros[2]);

        Console.WriteLine("Presione enter para continuar");
        Console.ReadLine();
    }
  }
}