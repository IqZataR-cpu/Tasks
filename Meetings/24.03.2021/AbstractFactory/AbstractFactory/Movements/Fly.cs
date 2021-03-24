using System;
using System.Security.Authentication;

namespace AbstractFactory.Movements
{
    public class Fly : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Вы летите");
        }
    }
}