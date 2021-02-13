using System;
using System.Linq;
using System.Collections.Generic;

namespace Application.Difficulties
{
    public abstract class Difficulty
    {
        public abstract Task SelectTask();

        public abstract string GetTitle();

        public abstract void PrintTasks();
    }
}