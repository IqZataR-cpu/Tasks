using System;

namespace AbstractFactory.Weapons
{
    public class Riffle : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Вы выстрелили из ружбая");
        }
    }
}