using System;

namespace ComputerScienseCyclesFlipNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int dataInput = Int32.Parse(Console.ReadLine());
            
                FlipNumberMethodOne(dataInput);
                FlipNumberMethodTwo(dataInput);
        }

        static void FlipNumberMethodOne(int dataInput)
        {
            int flipNumber = 0;
            string sizeDataInput = Convert.ToString(dataInput);
            
            for (int i = 0; i < sizeDataInput.Length; i++)
            {
                flipNumber = dataInput % 10;
                dataInput /= 10;
                
                Console.Write($"Метод 1.: {flipNumber}");
            }
        }

        static void FlipNumberMethodTwo(int dataInput)
        {
            int flipNumber = 0;

            while (dataInput > 0)
            {
                flipNumber = dataInput % 10;
                dataInput /= 10;
                
                Console.Write($"Метод 2.: {flipNumber}");
            }
        }
    }
}