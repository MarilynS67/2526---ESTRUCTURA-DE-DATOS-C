class Program
{
    static void Main()
    {
        // Mapa: ISBN -> Título del libro
        Dictionary<string, string> libros = new Dictionary<string, string>();

        // Conjunto: autores únicos
        HashSet<string> autores = new HashSet<string>();

        int opcion;

        do
        {
            Console.WriteLine("\n--- SISTEMA DE BIBLIOTECA ---");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Consultar libro por ISBN");
            Console.WriteLine("3. Mostrar todos los libros");
            Console.WriteLine("4. Mostrar autores únicos");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese ISBN: ");
                    string isbn = Console.ReadLine();

                    Console.Write("Ingrese título del libro: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Ingrese autor: ");
                    string autor = Console.ReadLine();

                    libros[isbn] = titulo;
                    autores.Add(autor);

                    Console.WriteLine("Libro registrado correctamente.");
                    break;

                case 2:
                    Console.Write("Ingrese ISBN a consultar: ");
                    string buscarIsbn = Console.ReadLine();

                    if (libros.ContainsKey(buscarIsbn))
                    {
                        Console.WriteLine("Título: " + libros[buscarIsbn]);
                    }
                    else
                    {
                        Console.WriteLine("Libro no encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("\nLista de libros registrados:");
                    foreach (var libro in libros)
                    {
                        Console.WriteLine("ISBN: " + libro.Key + " - Título: " + libro.Value);
                    }
                    break;

                case 4:
                    Console.WriteLine("\nAutores registrados:");
                    foreach (var a in autores)
                    {
                        Console.WriteLine(a);
                    }
                    break;

                case 5:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 5);
    }
}
