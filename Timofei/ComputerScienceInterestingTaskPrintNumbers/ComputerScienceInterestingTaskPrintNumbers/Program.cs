using System;
using System.Net.NetworkInformation;

namespace ComputerScienceInterestingTaskPrintNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i = 0;
            
            Print(i);
        }
        
        private static int Print(int i)
        {
            if (i < 100)
            {
                i++;
                
                Console.Write($"{i}, ");
                
                Print(i);
            }

            return i;
        }
    }
}