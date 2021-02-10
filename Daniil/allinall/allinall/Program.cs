using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace allinall
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            string userСhoice;
            Console.WriteLine("Добро пожаловать в программу, для выбора уровня сложности введите: Легки, Средний, Тяжелый, для выхода напиши ВЫХОД");
            

            while (true)
            {
                userСhoice = Console.ReadLine();

                if (userСhoice == "Легкий")
                {
                    easyDifficultyLevel.taskSelectionEZ();//вызов класса
                }
                else if (userСhoice == "Тяжелый")
                {
                    Console.WriteLine("Введите коректные данные22");//вызов класса
                }
                else if (userСhoice == "Средний")
                {
                    Console.WriteLine("Введите коректные данные333");//вызов класса
                }
                else if (userСhoice == "ВЫХОД")
                {
                    Console.WriteLine("Спасибо за использование програамы ");//вызов класса
                    break;
                }
                else
                {
                    Console.WriteLine("Введите коректные данные");
                }


            }



        }
    
    
    
    
    
    
    
    }
}