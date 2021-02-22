using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  n             = 15;
            int  FistNumber    = 0;
            int  SecondNumber  = 1;
            int  NeutralNumber = 1;
            
            Console.Write(FistNumber);
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($" " + NeutralNumber);
                
                NeutralNumber = FistNumber + SecondNumber;
                
                FistNumber    = SecondNumber;
                
                SecondNumber  = NeutralNumber;
            }
        }
    }
}