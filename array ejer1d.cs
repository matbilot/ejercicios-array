using System;
namespace GuiaArreglos
{
  class Ejercicio03
  {
    static void Main(string[] args)
    {
        Console.WriteLine("ejer 3: fundamentos de arreglo");
        int[] numeros = new int[3];
        numeros[0] = -10;
        numeros[1] = 0;
        numeros[2] = 10;

        Console.WriteLine("valor en indice 0: " + numeros[0]);
        Console.WriteLine("valor en indice 1: " + numeros[1]);
        Console.WriteLine("valor en indice 2: " + numeros[2]);

        Console.WriteLine("Presione enter para continuar");
        Console.ReadLine();
    }
  }
}