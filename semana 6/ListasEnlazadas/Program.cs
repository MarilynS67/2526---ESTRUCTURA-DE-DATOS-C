// Nodo de la lista
class Nodo
{
    public int Dato;
    public Nodo Siguiente;

    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

// Lista enlazada
class ListaEnlazada
{
    private Nodo cabeza;

    // Insertar al final
    public void Insertar(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // EJERCICIO 1: Contar elementos
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }

    // EJERCICIO 2: Invertir lista
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        cabeza = anterior;
    }

    // Mostrar lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.Dato + " -> ");
            actual = actual.Siguiente;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.Insertar(10);
        lista.Insertar(20);
        lista.Insertar(30);
        lista.Insertar(40);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        Console.WriteLine("Número de elementos: " + lista.ContarElementos());

        lista.Invertir();
        Console.WriteLine("Lista invertida:");
        lista.Mostrar();
    }
}
