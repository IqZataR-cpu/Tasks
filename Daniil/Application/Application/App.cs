using System;
using System.Collections.Generic;
using System.Linq;
using Application.Difficulties;

namespace Application
{
    public class App
    {
        private readonly Dictionary<string, Difficulty> _difficulties = new Dictionary<string, Difficulty>()
        {
            {"Легкий", new Easy()},
        };

        public void Run()
        {
            Task task;
            Difficulty difficulty;
            
            Console.WriteLine("Добро пожаловать в программу!");

            while (true)
            {
                PrintDifficulties();
                
                difficulty = ChangeDifficulty(Console.ReadLine());
                
                Console.WriteLine(difficulty.GetTitle());
                difficulty.PrintTasks();
                
                task = difficulty.SelectTask();
                task.Solution();
            }
        }

        private Difficulty ChangeDifficulty(string userChoice)
        {
            return _difficulties.ContainsKey(userChoice) ? _difficulties[userChoice] : new NullDifficulty();
        }

        private void PrintDifficulties()
        {
            Console.Write("Для выбора уровня сложности введите:" 
                          + GetDifficulties() + ":");
        }
        
        private string GetDifficulties()
        {
            return _difficulties.Aggregate(
                "", 
                (current, item) => $"{current}{item.Key}, "
            ).Trim().Trim(',');
        }
    }
}