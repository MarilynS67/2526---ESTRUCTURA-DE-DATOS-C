

class Ejercicio5
{
    public static void Ejecutar()
    {
        Curso curso = new Curso();
        curso.Asignaturas.Reverse();

        Console.WriteLine("Asignaturas en orden inverso:");
        foreach (string asignatura in curso.Asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
