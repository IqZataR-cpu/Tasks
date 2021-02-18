using System;

namespace ObjectOrintiedProgramming.Mobs
{
    public class Shaman : Orc
    {
        public Shaman(int health, int damage) : base(health, damage)
        {
            
        }

        public override void SayGreetings()
        {
            Console.WriteLine("ZAG ZAG");
        }
    }
}