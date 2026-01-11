
class Ejercicio2
{
    public static void Ejecutar()
    {
        Curso curso = new Curso();

        foreach (string asignatura in curso.Asignaturas)
        {
            Console.WriteLine($"Yo estudio {asignatura}");
        }
    }
}
