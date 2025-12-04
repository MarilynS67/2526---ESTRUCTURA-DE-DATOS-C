namespace FigurasGeometricas
{
    // -------------------------------------------------------------
    // CLASE CÍRCULO
    // -------------------------------------------------------------
    public class Circulo
    {
        // Campo privado que almacena el radio del círculo
        private double radio;

        // Propiedad pública para acceder al radio
        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        // Constructor que recibe el radio
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        // Método para calcular el perímetro del círculo
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // -------------------------------------------------------------
    // CLASE RECTÁNGULO
    // -------------------------------------------------------------
    public class Rectangulo
    {
        // Campos privados
        private double baseRect;
        private double altura;

        // Propiedades públicas
        public double Base
        {
            get { return baseRect; }
            set { baseRect = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        // Constructor
        public Rectangulo(double baseRect, double altura)
        {
            this.baseRect = baseRect;
            this.altura = altura;
        }

        // Método para calcular el área del rectángulo
        public double CalcularArea()
        {
            return baseRect * altura;
        }

        // Método para calcular el perímetro del rectángulo
        public double CalcularPerimetro()
        {
            return 2 * (baseRect + altura);
        }
    }

    // -------------------------------------------------------------
    // PROGRAMA PRINCIPAL – SE MUESTRA TODO EN LA CONSOLA
    // -------------------------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CÁLCULO DE FIGURAS GEOMÉTRICAS =====\n");

            // Crear un círculo con radio 3.5
            Circulo circ = new Circulo(3.5);
            Console.WriteLine(">>> DATOS DEL CÍRCULO");
            Console.WriteLine("Radio: " + circ.Radio);
            Console.WriteLine("Área: " + circ.CalcularArea());
            Console.WriteLine("Perímetro: " + circ.CalcularPerimetro());
            Console.WriteLine();

            // Crear un rectángulo con base 8 y altura 4.2
            Rectangulo rect = new Rectangulo(8, 4.2);
            Console.WriteLine(">>> DATOS DEL RECTÁNGULO");
            Console.WriteLine("Base: " + rect.Base);
            Console.WriteLine("Altura: " + rect.Altura);
            Console.WriteLine("Área: " + rect.CalcularArea());
            Console.WriteLine("Perímetro: " + rect.CalcularPerimetro());
            Console.WriteLine();

            Console.WriteLine("Cálculos finalizados. Presiona cualquier tecla para cerrar...");
            Console.ReadKey();
        }
    }
}
