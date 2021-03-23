using System;

namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public abstract class Player
    {
        private string _name;
        private int _health;
        private string _weapon;

        public string Name => _name;

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public string Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }

        public Player(string name, int health, string weapon)
        {
            _name = name;
            _health = health;
            _weapon = weapon;
        }

        public void Attack(Player target, Player damage);
        
        public void Print()
        {
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Жизни: {_health}");
            Console.WriteLine($"Оружие: {_weapon}");
            
            if (_weapon == "Пистолет")
            {
                Pistol.Print();
            }
            else
            {
                Knife.Print();
            }
        }
    }
}