
// -------------------- ARBOL --------------------
class Nodo
{
    public int valor;
    public Nodo izquierda, derecha;

    public Nodo(int valor)
    {
        this.valor = valor;
        izquierda = derecha = null;
    }
}

class Arbol
{
    public Nodo raiz;

    public void Insertar(int valor)
    {
        raiz = InsertarRec(raiz, valor);
    }

    private Nodo InsertarRec(Nodo raiz, int valor)
    {
        if (raiz == null)
        {
            raiz = new Nodo(valor);
            return raiz;
        }

        if (valor < raiz.valor)
            raiz.izquierda = InsertarRec(raiz.izquierda, valor);
        else
            raiz.derecha = InsertarRec(raiz.derecha, valor);

        return raiz;
    }

    public void InOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            InOrden(raiz.izquierda);
            Console.Write(raiz.valor + " ");
            InOrden(raiz.derecha);
        }
    }
}

// -------------------- GRAFO --------------------
class Grafo
{
    private Dictionary<int, List<int>> lista = new Dictionary<int, List<int>>();

    public void AgregarNodo(int nodo)
    {
        if (!lista.ContainsKey(nodo))
            lista[nodo] = new List<int>();
    }

    public void AgregarArista(int origen, int destino)
    {
        lista[origen].Add(destino);
        lista[destino].Add(origen);
    }

    public void Mostrar()
    {
        foreach (var nodo in lista)
        {
            Console.Write(nodo.Key + " -> ");
            foreach (var vecino in nodo.Value)
            {
                Console.Write(vecino + " ");
            }
            Console.WriteLine();
        }
    }
}

// -------------------- MAIN --------------------
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== ARBOL ===");

        Arbol arbol = new Arbol();
        arbol.Insertar(5);
        arbol.Insertar(3);
        arbol.Insertar(7);
        arbol.Insertar(1);
        arbol.Insertar(4);

        Console.Write("Recorrido InOrden: ");
        arbol.InOrden(arbol.raiz);

        Console.WriteLine("\n\n=== GRAFO ===");

        Grafo grafo = new Grafo();
        grafo.AgregarNodo(1);
        grafo.AgregarNodo(2);
        grafo.AgregarNodo(3);

        grafo.AgregarArista(1, 2);
        grafo.AgregarArista(2, 3);

        grafo.Mostrar();
    }
}
