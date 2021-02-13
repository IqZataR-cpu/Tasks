using System;
using System.Collections.Generic;
using System.Linq;

namespace  Application.Difficulties
{
    public class Easy : Difficulty
    {
        private const string Title = "Вы выбрали легкий уровень сложности";
        
        private readonly Dictionary<string, Task> _tasks = new Dictionary<string, Task>()
        {
            {"Условия", new DeterminesParityOfNum()},
        };

        public override Task SelectTask()
        {
            string userChoice = Console.ReadLine();

            return _tasks.ContainsKey(userChoice) ? _tasks[userChoice] : new NullTask();
        }

        public override string GetTitle()
        {
            return Title;
        }
        
        public override void PrintTasks()
        {
            Console.Write($"Выберите задание: {GetTasks()}:");
        }

        private string GetTasks()
        {
            return _tasks.Aggregate(
                "", 
                (current, item) => $"{current}{item.Key}, "
            ).Trim().Trim(',');
        }
    }
}