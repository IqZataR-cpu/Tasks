using System;
using System.Net.Sockets;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public abstract class Weapon
    {
        private string _name;
        private int _damage;
        private int _ammunition;

        public string Name => _name;

        public int Damage => _damage;

        public int Ammunition
        {
            get => _ammunition;
            set => _ammunition = value;
        }

        public Weapon(string name, int damage, int ammunition)
        {
            _name = name;
            _damage = damage;
            _ammunition = ammunition;
        }

        public abstract void ReloadAmmo();
        
        public void ToDamage(Weapon weapon, Players target)
        {
            if (GetStateHealth(target))
            {
                if (weapon is FireArms)
                {
                    TryApplyDamage(weapon.Damage, target);
                    weapon._ammunition --;
                }
                else
                {
                    TryApplyDamage(weapon.Damage, target);
                }
            }
        }
        
        public static bool GetStateHealth(Players target)
        {
            return target.Health > 0;
        }
        public void TryApplyDamage(int toDamage, Players target)
        {
            if (target.Health < toDamage)
            {
                PrintDeadEnemy();
                
                target.Health = Players.MINHEALTH;
            }
            else
            {
                target.Health -= toDamage;   
            }
        }
        
        public void ReloadAmmo(Weapon weapon)
        {
            if (weapon is FireArms)
            {
                weapon.ReloadAmmo();
            }
            else
            {
                Console.WriteLine($"Перезарядить {weapon.Name} ? Ты псих.");
            }
        }
        
        private static void PrintDeadEnemy()
        {
            Console.WriteLine("Враг убит!");
        }
    }
}