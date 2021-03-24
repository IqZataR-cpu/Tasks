using System;

namespace AbstractFactory.Weapons
{
    public class Knife : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Вы ударили ножом");
        }
    }
}