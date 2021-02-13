using System;

namespace Application
{
    public class NullTask : Task
    {
        public override void Solution()
        {
            Console.WriteLine("Задание не реализовано");
        }
    }
}