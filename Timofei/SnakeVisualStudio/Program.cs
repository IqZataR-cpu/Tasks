using System;

namespace Snake
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Выбери вариант действий: " +
                              "\n1. Начать игру." + 
                              "\n2. Выход");
            
            string choiceUser = Console.ReadLine();
            
            ChoiseUser(choiceUser);
        }

        public static void ChoiseUser(string choice)
        {
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    
                    Game firstGame = new Game();

                    firstGame.Run();
                    break;
                case "2":
                    Console.WriteLine("Пока!");
                    
                    return;
                    break;
                default:
                    Console.WriteLine("Нет такого варианта");
                    break;
            }
        }
    }
}