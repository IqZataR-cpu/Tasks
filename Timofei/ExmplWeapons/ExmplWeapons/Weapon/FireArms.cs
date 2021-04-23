using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class FireArms : Weapon
    {
        protected readonly int MaxAmmunation;
        
        private int _ammunition;
        
        public FireArms(string name, int damage, int ammunition) : base(name, damage)
        {
            _ammunition = ammunition;
        }
        
        public override void ReloadAmmo()
        {
            _ammunition = MaxAmmunation;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Ammunition: {_ammunition} \n");
        }
    }
}