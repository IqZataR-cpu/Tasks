using System;

namespace AbstractFactory.Movements
{
    public class Run : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Вы бежите");
        }
    }
}