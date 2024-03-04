using System.Text;
namespace AulasAI.Collections;
public class Node<T> : INode<T>
{
    public T Value { get; set; }
    public List<Node<T>> Vizinhos { get; set; }
    public int Conexoes => Vizinhos.Count;

    public Node(
        T value = default(T),
        List<Node<T>> vizinhos = null //pode ter vizinhos
    )
    {
        Value = value;
        Vizinhos = vizinhos ?? new List<Node<T>>();
    }

    public Node<T> AddVizinhos(Node<T> node)
    {
        Vizinhos.Add(node);
        node.Vizinhos.Add(this);

        return this;
    }

    public Node<T> RemoveVizinhos(Node<T> node)
    {
        Vizinhos.Remove(node);
        node.Vizinhos.Remove(this);

        return this;
    }
}

