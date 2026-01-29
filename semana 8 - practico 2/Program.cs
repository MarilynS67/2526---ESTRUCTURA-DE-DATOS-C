class ProgramaAsientos
{
    static void Main(string[] args)
    {
        Queue<string> cola = new Queue<string>();
        int capacidad = 30;
        int opcion = 0;

        do
        {
            Console.WriteLine("\n--- SISTEMA DE ASIGNACIÓN DE ASIENTOS ---");
            Console.WriteLine("1. Registrar persona en la cola");
            Console.WriteLine("2. Asignar asiento");
            Console.WriteLine("3. Ver personas en espera");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    if (cola.Count < capacidad)
                    {
                        Console.Write("Ingrese el nombre de la persona: ");
                        string nombre = Console.ReadLine();
                        cola.Enqueue(nombre);
                        Console.WriteLine("Persona registrada correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("No hay asientos disponibles.");
                    }
                    break;

                case 2:
                    if (cola.Count > 0)
                    {
                        string personaAtendida = cola.Dequeue();
                        Console.WriteLine($"Asiento asignado a: {personaAtendida}");
                    }
                    else
                    {
                        Console.WriteLine("No hay personas en la cola.");
                    }
                    break;

                case 3:
                    if (cola.Count > 0)
                    {
                        Console.WriteLine("\nPersonas en la cola:");
                        foreach (string persona in cola)
                        {
                            Console.WriteLine(persona);
                        }
                    }
                    else
                    {
                        Console.WriteLine("La cola está vacía.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 4);
    }
}
