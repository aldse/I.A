using AulasAI.Collections;

namespace AulasAI.Search;
public static partial class Search
{
    public static bool BFSearch<T>(TreeNode<T> nodearvore, T meta) //Pesquisa ampla
    {
        var fila = new Queue<TreeNode<T>>(); //nova fila de no de arvore
        fila.Enqueue(nodearvore);

        while (fila.Count > 0)
        {
            var noatual = fila.Dequeue();

            if (EqualityComparer<T>.Default.Equals(noatual.Value, meta))
                return true;

            foreach (var filhos in noatual.Children)
                fila.Enqueue(filhos);
        }
        return false;
    }
}
