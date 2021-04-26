using System;

namespace PrintOneToHundred
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 'A' / 'A';
            String s = "..........";

            for (int i = one; i <= s.Length * s.Length; i++)
            {
                Console.Write($"{i} ");
            }                
        }
    }
}
