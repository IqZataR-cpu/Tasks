using System;
using System.Collections.Generic;

namespace HashSet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<char> setA = new HashSet<char>();
            HashSet<char> setB = new HashSet<char>();
            HashSet<char> setC = new HashSet<char>();

            setA.Add('X');
            setB = SetSymbols();
            setC.UnionWith(setA);
            setC.UnionWith(setB);

            setA.UnionWith(setB);
            Console.WriteLine("Объединение множеств :");
            PrintSet(setC);

            setA.IntersectWith(setB);
            Console.WriteLine("\nПересечение множеств :");
            PrintSet(setA);

            setC.ExceptWith(setB);
            Console.WriteLine("\nРазность множеств :");
            PrintSet(setC);

            setC.Add('E');
            setC.UnionWith(setB);
            setB.Add('Z');

            setC.SymmetricExceptWith(setB);
            Console.WriteLine("\nСимметрическая разность множеств:");
            PrintSet(setC);
        }

        private static HashSet<char> SetSymbols()
        {
            HashSet<char> set = new HashSet<char>();

            set.Add('A');
            set.Add('B');
            set.Add('C');
            set.Add('D');

            return set;
        }

        private static void PrintSet(HashSet<char> set)
        {
            foreach (var itemSet in set)
            {
                Console.Write($"{itemSet} ");
            }
        }
    }
}
