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

            Console.WriteLine(conjunto.Contains("Computer")); //vai verificar se no conjunto contem Computer

        }
    }
}
