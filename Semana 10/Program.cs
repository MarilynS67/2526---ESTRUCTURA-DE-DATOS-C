class Program
{
    static void Main()
    {
        // Conjunto de 500 ciudadanos
        HashSet<string> ciudadanos = new HashSet<string>();
        for (int i = 1; i <= 500; i++)
        {
            ciudadanos.Add("Ciudadano " + i);
        }

        // 75 ciudadanos vacunados con Pfizer
        HashSet<string> pfizer = new HashSet<string>();
        for (int i = 1; i <= 75; i++)
        {
            pfizer.Add("Ciudadano " + i);
        }

        // 75 ciudadanos vacunados con AstraZeneca
        HashSet<string> astraZeneca = new HashSet<string>();
        for (int i = 76; i <= 150; i++)
        {
            astraZeneca.Add("Ciudadano " + i);
        }

        // Ambas dosis (intersección)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astraZeneca);

        // Solo Pfizer
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astraZeneca);

        // Solo AstraZeneca
        HashSet<string> soloAstra = new HashSet<string>(astraZeneca);
        soloAstra.ExceptWith(pfizer);

        // No vacunados
        HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
        noVacunados.ExceptWith(pfizer);
        noVacunados.ExceptWith(astraZeneca);

        // Mostrar resultados
        Console.WriteLine("CIUDADANOS NO VACUNADOS:");
        Mostrar(noVacunados);

        Console.WriteLine("\nCIUDADANOS CON AMBAS DOSIS:");
        Mostrar(ambasDosis);

        Console.WriteLine("\nCIUDADANOS SOLO PFIZER:");
        Mostrar(soloPfizer);

        Console.WriteLine("\nCIUDADANOS SOLO ASTRAZENECA:");
        Mostrar(soloAstra);
    }

    static void Mostrar(HashSet<string> conjunto)
    {
        foreach (var ciudadano in conjunto)
        {
            Console.WriteLine(ciudadano);
        }
        Console.WriteLine("Total: " + conjunto.Count);
    }
}
