using System;

namespace Application.Difficulties
{
    public class NullDifficulty : Difficulty
    {
        public override Task SelectTask()
        {
            return new NullTask();
        }

        public override string GetTitle()
        {
            return "Сложность не реализована";
        }

        public override void PrintTasks() { }
    }
}