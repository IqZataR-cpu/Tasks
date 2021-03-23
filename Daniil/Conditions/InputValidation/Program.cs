using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionsTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Введите число");
            number = Convert.ToInt32(Console.ReadLine());

            if (number == 10)
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Не верно");
            }

            Console.ReadKey();
        }
    }
}
