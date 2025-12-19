
namespace AgendaTelefonica
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
    }

    class Program
    {
        static Contacto[] agenda = new Contacto[50];
        static int totalContactos = 0;

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.WriteLine("\n===== AGENDA TELEFÓNICA =====");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Mostrar contactos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarContacto();
                        break;
                    case 2:
                        MostrarContactos();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            } while (opcion != 3);
        }

        static void AgregarContacto()
        {
            if (totalContactos >= agenda.Length)
            {
                Console.WriteLine("La agenda está llena.");
                return;
            }

            Contacto nuevo = new Contacto();

            Console.Write("Nombre: ");
            nuevo.Nombre = Console.ReadLine();

            Console.Write("Teléfono: ");
            nuevo.Telefono = Console.ReadLine();

            Console.Write("Correo: ");
            nuevo.Correo = Console.ReadLine();

            agenda[totalContactos] = nuevo;
            totalContactos++;

            Console.WriteLine("Contacto agregado correctamente.");
        }

        static void MostrarContactos()
        {
            if (totalContactos == 0)
            {
                Console.WriteLine("No existen contactos registrados.");
                return;
            }

            Console.WriteLine("\n--- LISTA DE CONTACTOS ---");

            for (int i = 0; i < totalContactos; i++)
            {
                Console.WriteLine($"\nContacto {i + 1}");
                Console.WriteLine($"Nombre: {agenda[i].Nombre}");
                Console.WriteLine($"Teléfono: {agenda[i].Telefono}");
                Console.WriteLine($"Correo: {agenda[i].Correo}");
            }
        }
    }
}
