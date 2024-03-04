using AulasAI.Collections;

namespace AulasAI.Search;
//tree = arvore
//node = nó
public static partial class Search
{
    public static bool DFSearch<T>(TreeNode<T> nodearvore, T meta) //Primeira pesquisa em profundidade
    {
        if (EqualityComparer<T>.Default.Equals(nodearvore.Value, meta))
            return true;

        foreach (var noatual in nodearvore.Children)
        {
            if (EqualityComparer<T>.Default.Equals(noatual.Value, meta) || DFSearch(noatual, meta))
                return true;
            // else
            //     DepthFirstSearch<T>(noatual, meta);
            //SUBISTITUI O DE CIMA POR ISSO
            // return DepthFirstSearch(noatual, meta);
            // if(DepthFirstSearch(noatual, meta)) //colocado no if para minimizar
            //     return true;
        }
        return false;
    }
}