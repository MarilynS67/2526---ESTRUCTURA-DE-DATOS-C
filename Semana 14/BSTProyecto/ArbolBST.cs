public class ArbolBST
{
    public Nodo Raiz;

    public void Insertar(int valor)
    {
        Raiz = InsertarRec(Raiz, valor);
    }

    private Nodo InsertarRec(Nodo raiz, int valor)
    {
        if (raiz == null)
            return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = InsertarRec(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = InsertarRec(raiz.Derecho, valor);

        return raiz;
    }

    public bool Buscar(int valor)
    {
        return BuscarRec(Raiz, valor);
    }

    private bool BuscarRec(Nodo raiz, int valor)
    {
        if (raiz == null) return false;
        if (raiz.Valor == valor) return true;

        if (valor < raiz.Valor)
            return BuscarRec(raiz.Izquierdo, valor);
        else
            return BuscarRec(raiz.Derecho, valor);
    }

    public void Inorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Inorden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            Inorden(raiz.Derecho);
        }
    }

    public void Preorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            Preorden(raiz.Izquierdo);
            Preorden(raiz.Derecho);
        }
    }

    public void Postorden(Nodo raiz)
    {
        if (raiz != null)
        {
            Postorden(raiz.Izquierdo);
            Postorden(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }

    public int Minimo()
    {
        Nodo actual = Raiz;
        while (actual.Izquierdo != null)
            actual = actual.Izquierdo;
        return actual.Valor;
    }

    public int Maximo()
    {
        Nodo actual = Raiz;
        while (actual.Derecho != null)
            actual = actual.Derecho;
        return actual.Valor;
    }

    public int Altura(Nodo raiz)
    {
        if (raiz == null)
            return -1;

        return 1 + Math.Max(Altura(raiz.Izquierdo), Altura(raiz.Derecho));
    }

    public void Limpiar()
    {
        Raiz = null;
    }
}