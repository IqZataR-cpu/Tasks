using System;
using System.Net.NetworkInformation;

namespace ComputerScienceInterestingTaskPrintNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            Print(i);
        }
        
        static int Print(int i)
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