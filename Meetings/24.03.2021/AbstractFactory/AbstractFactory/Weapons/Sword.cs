using System;

namespace AbstractFactory.Weapons
{
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Вы ударили мечом");
        }
    }
}