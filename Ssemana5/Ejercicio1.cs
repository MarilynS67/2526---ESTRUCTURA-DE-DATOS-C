class Ejercicio1
{
    public static void Ejecutar()
    {
        Curso curso = new Curso();

        foreach (string asignatura in curso.Asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}
