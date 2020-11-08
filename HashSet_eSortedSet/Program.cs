using System;
using System.Collections.Generic;

namespace HashSet_eSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> conjuntoA = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 9 };
            SortedSet<int> conjuntoB = new SortedSet<int>() { 1, 3, 5, 7, 8, 9, 10 };

            ImprimirConjunto(conjuntoA);
            ImprimirConjunto(conjuntoB);

            Console.WriteLine();
            Console.Write("União: ");
            SortedSet<int> conjuntoC = new SortedSet<int>(conjuntoA);
            conjuntoC.UnionWith(conjuntoB);
            ImprimirConjunto(conjuntoC);



            Console.ReadKey();
        }

        static void ImprimirConjunto<T>(IEnumerable<T> conjunto)
        {
            foreach (T objeto in conjunto)
            {
                Console.Write(objeto + " ");
            }
            Console.WriteLine();
        }

    }
}
