using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Pistol : Weapon
    {
        private const int DAMAGE = 55;
        private const int AMMUNITION = 7;
        
        public static void Print()
        {
            Console.WriteLine($"Урон: {DAMAGE}");
            Console.WriteLine($"Патроны: {AMMUNITION} \n");
        }
        
        public Pistol(int damage, int ammunition) : base(damage, ammunition)
        {
        }
    }
}