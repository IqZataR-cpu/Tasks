using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class SteelArms : Weapon
    {
        public SteelArms(string name, int damage) : base(name, damage)
        {
        }

        public override void ReloadAmmo()
        {
            Console.WriteLine($"Перезарядить {Name} ? Ты псих.");
        }

        public override void MinusAmmo()
        {
        }
    }
}