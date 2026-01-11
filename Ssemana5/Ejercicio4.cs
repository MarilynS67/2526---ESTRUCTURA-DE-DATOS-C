
using System.Collections.Generic;

class Ejercicio4
{
    public static void Ejecutar()
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Ingresa 6 números de la lotería:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros.Add(int.Parse(Console.ReadLine()));
        }

        numeros.Sort();

        Console.WriteLine("\nNúmeros ordenados:");
        foreach (int n in numeros)
        {
            Console.Write(n + " ");
        }
    }
}
