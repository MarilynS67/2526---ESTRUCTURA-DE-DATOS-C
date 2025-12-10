
namespace RegistroEstudiante
{
    // Definición de la clase Estudiante
    class Estudiante
    {
        public int ID;
        public string Nombres;
        public string Apellidos;
        public string Direccion;
        public string[] Telefonos = new string[3];

        // Método para mostrar la información del estudiante
        public void MostrarDatos()
        {
            Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);

            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();

            Console.Write("Ingrese ID: ");
            estudiante.ID = int.Parse(Console.ReadLine());

            Console.Write("Ingrese nombres: ");
            estudiante.Nombres = Console.ReadLine();

            Console.Write("Ingrese apellidos: ");
            estudiante.Apellidos = Console.ReadLine();

            Console.Write("Ingrese dirección: ");
            estudiante.Direccion = Console.ReadLine();

            // Ingreso de teléfonos usando array
            for (int i = 0; i < estudiante.Telefonos.Length; i++)
            {
                Console.Write($"Ingrese teléfono {i + 1}: ");
                estudiante.Telefonos[i] = Console.ReadLine();
            }

            // Mostrar los datos ingresados
            estudiante.MostrarDatos();

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

