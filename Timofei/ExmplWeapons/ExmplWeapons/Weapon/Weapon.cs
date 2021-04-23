using System;
using System.Net.Sockets;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public abstract class Weapon
    {
        private string _name;
        private int _damage;

        public string Name => _name;

        public Weapon(string name, int damage)
        {
            _name = name;
            _damage = damage;
        }

        public abstract void ReloadAmmo();
        
        public void Hit(Players target)
        {
            target.TryApplyDamage(_damage);
        }

        public virtual void Print()
        {
            Console.WriteLine($"Weapon: {_name}");
            Console.WriteLine($"Damage: {_damage}");
        }
    }
}