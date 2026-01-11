
using System.Collections.Generic;

class Ejercicio3
{
    public static void Ejecutar()
    {
        Curso curso = new Curso();
        Dictionary<string, double> notas = new Dictionary<string, double>();

        foreach (string asignatura in curso.Asignaturas)
        {
            Console.Write($"Ingresa la nota de {asignatura}: ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(asignatura, nota);
        }

        Console.WriteLine("\nResultados:");
        foreach (var item in notas)
        {
            Console.WriteLine($"En {item.Key} has sacado {item.Value}");
        }
    }
}
