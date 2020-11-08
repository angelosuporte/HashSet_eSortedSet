using System;
using System.Collections.Generic;

namespace HashSet_eSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> conjunto = new HashSet<string>();

            conjunto.Add("TV");
            conjunto.Add("Notebook");
            conjunto.Add("Tablet");

            foreach (string item in conjunto)
            {
                Console.WriteLine(item);
            }

        }
    }
}
