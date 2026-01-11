
class Curso
{
    public List<string> Asignaturas { get; set; }

    public Curso()
    {
        Asignaturas = new List<string>
        {
            "Matemáticas",
            "Física",
            "Química",
            "Historia",
            "Lengua"
        };
    }
}
