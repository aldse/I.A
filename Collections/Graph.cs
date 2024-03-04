namespace AulasAI.Collections;

public class Graph<T> : Node<T> //herdando de node 
{
    public Graph( //construtor 
        T value = default(T),
        List<Borda<T>> vizinhos = null! //Borda = Edge
    )
        : base(value.vizinhos) { }
}