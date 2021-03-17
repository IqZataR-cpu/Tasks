using System;


namespace oopEasy
{
    public abstract class Orc : IDamagable
    {
        protected string _name;
        protected int _health;
        protected int _stamina;
        protected int _armor;
        protected int _damage;
        protected int _moveSpeed;
        protected int _position = 0;

        protected Orc(string name)
        {
            _name = name;
        }

        public virtual void Attack(IDamagable target)
        {

        }

        public virtual void TakeDamage(int damage)
        {

        }

        public virtual void Print()
        {
            Console.WriteLine($"\nИмя: {_name}");
            Console.WriteLine($"Здоровье: {_health}");
            Console.WriteLine($"Скорость:{_stamina}");
            Console.WriteLine($"Наносимый урон:{_armor}");
            Console.WriteLine($"Броня:{_damage}");
            Console.WriteLine($"Скорость:{_moveSpeed}");
            Console.WriteLine($"Текущая позиция:{_position}\n");
        }
    }
}