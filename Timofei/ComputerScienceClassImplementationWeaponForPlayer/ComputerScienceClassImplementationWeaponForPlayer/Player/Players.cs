using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Players
    {
        public const int MINHEALTH = 0;

        private string _name;
        private int _health;
        private Weapon _weapon;

        public string Name => _name;

        public int Health
        {
            get => _health;
            set => _health = value;
        }
        
        protected Players(string name, int health, Weapon weapon)
        {
            _name = name;
            _health = health;
            _weapon = weapon;
        }

        public void Hit(Players target)
        {
            _weapon.ToDamage(_weapon, target);
        }

        public void Reload()
        {
            _weapon.ReloadAmmo(_weapon);
        }
        
        public void SwapWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }
        
        public void Print()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Weapon: {_weapon.Name}");
            Console.WriteLine($"Damage: {_weapon.Damage}");
            Console.WriteLine($"Ammunition: {_weapon.Ammunition} \n");
        }
    }
}