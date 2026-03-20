class Program
{
    static void Main()
    {
        ArbolBST arbol = new ArbolBST();
        int opcion, valor;

        do
        {
            Console.WriteLine("\n--- MENU BST ---");
            Console.WriteLine("1. Insertar");
            Console.WriteLine("2. Buscar");
            Console.WriteLine("3. Mostrar Inorden");
            Console.WriteLine("4. Mostrar Preorden");
            Console.WriteLine("5. Mostrar Postorden");
            Console.WriteLine("6. Minimo");
            Console.WriteLine("7. Maximo");
            Console.WriteLine("8. Altura");
            Console.WriteLine("9. Limpiar");
            Console.WriteLine("0. Salir");

            Console.Write("Seleccione: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Valor: ");
                    valor = int.Parse(Console.ReadLine());
                    arbol.Insertar(valor);
                    break;

                case 2:
                    Console.Write("Buscar: ");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol.Buscar(valor) ? "Encontrado" : "No encontrado");
                    break;

                case 3:
                    arbol.Inorden(arbol.Raiz);
                    break;

                case 4:
                    arbol.Preorden(arbol.Raiz);
                    break;

                case 5:
                    arbol.Postorden(arbol.Raiz);
                    break;

                case 6:
                    Console.WriteLine("Min: " + arbol.Minimo());
                    break;

                case 7:
                    Console.WriteLine("Max: " + arbol.Maximo());
                    break;

                case 8:
                    Console.WriteLine("Altura: " + arbol.Altura(arbol.Raiz));
                    break;

                case 9:
                    arbol.Limpiar();
                    Console.WriteLine("Arbol limpio");
                    break;
            }

        } while (opcion != 0);
    }
}
