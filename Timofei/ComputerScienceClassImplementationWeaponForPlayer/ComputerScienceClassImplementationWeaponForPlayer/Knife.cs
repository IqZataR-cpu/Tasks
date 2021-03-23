using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Knife : Weapon
    {
        private const int DAMAGE = 35;
        
        public static void Print()
        {
            Console.WriteLine($"Урон: {DAMAGE} \n");
        }
        
        public Knife(int damage) : base(damage)
        {
        }
    }
}