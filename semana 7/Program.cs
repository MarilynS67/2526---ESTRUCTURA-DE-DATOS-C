class Program
{
    static void Main()
    {
        Console.WriteLine("1. Verificar paréntesis balanceados");
        Console.WriteLine("2. Torres de Hanoi");
        Console.Write("Seleccione una opción: ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
        {
            Console.Write("Ingrese la expresión: ");
            string expresion = Console.ReadLine();

            Console.WriteLine(
                EstaBalanceada(expresion)
                ? "Fórmula balanceada."
                : "Fórmula NO balanceada."
            );
        }
        else if (opcion == 2)
        {
            Console.Write("Ingrese el número de discos: ");
            int n = int.Parse(Console.ReadLine());

            Stack<int> origen = new Stack<int>();
            Stack<int> auxiliar = new Stack<int>();
            Stack<int> destino = new Stack<int>();

            for (int i = n; i >= 1; i--)
                origen.Push(i);

            ResolverHanoi(n, origen, destino, auxiliar, "Origen", "Destino", "Auxiliar");
        }
    }

    static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char c in expresion)
        {
            if (c == '(' || c == '{' || c == '[')
                pila.Push(c);
            else if (c == ')' || c == '}' || c == ']')
            {
                if (pila.Count == 0) return false;
                char tope = pila.Pop();
                if (!Coinciden(tope, c)) return false;
            }
        }
        return pila.Count == 0;
    }

    static bool Coinciden(char a, char c)
    {
        return (a == '(' && c == ')') ||
               (a == '{' && c == '}') ||
               (a == '[' && c == ']');
    }

    static void ResolverHanoi(
        int n,
        Stack<int> origen,
        Stack<int> destino,
        Stack<int> auxiliar,
        string nomOrigen,
        string nomDestino,
        string nomAux)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nomOrigen} a {nomDestino}");
            return;
        }

        ResolverHanoi(n - 1, origen, auxiliar, destino, nomOrigen, nomAux, nomDestino);

        int d = origen.Pop();
        destino.Push(d);
        Console.WriteLine($"Mover disco {d} de {nomOrigen} a {nomDestino}");

        ResolverHanoi(n - 1, auxiliar, destino, origen, nomAux, nomDestino, nomOrigen);
    }
}
