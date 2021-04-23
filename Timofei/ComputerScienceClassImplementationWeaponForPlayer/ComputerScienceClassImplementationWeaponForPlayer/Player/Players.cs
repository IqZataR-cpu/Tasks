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

        protected Players(string name, int health, Weapon weapon)
        {
            _name = name;
            _health = health;
            _weapon = weapon;
        }

        public void Hit(Players target)
        {
            _weapon.Hit(target);
        }

        public void Reload()
        {
            _weapon.ReloadAmmo();
        }
        
        public void SwapWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }
        
        public void TryApplyDamage(int toDamage)
        {
            if (_health < toDamage)
            {
                PrintDeadEnemy();
                
                _health = MINHEALTH;
            }
            else
            {
                _health -= toDamage;
            }
        }

        public void Print()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Health: {_health}");
            
            _weapon.Print();
        }
        
        private static void PrintDeadEnemy()
        {
            Console.WriteLine("Враг убит!");
        }
    }
}