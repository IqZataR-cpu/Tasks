using System;


namespace oopEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Shaman Trall = new Shaman("Trall", 150, 150, 10, 30, 5);
           // Shaman Recsar = new Hunter();
            Shaman Garrosh = new Shaman("Garrosh", 150, 150, 10, 30, 5);
            Trall.Print();
            Trall.Greet();
            Trall.Moving();
            Trall.Attack(Garrosh);
            Trall.Rest();
            Trall.Print();
/*
            Trall.Print();
            Trall.Greet();
            Trall.Moving();
            Trall.Attack(Garrosh);
            Trall.Rest();
            Trall.Print();
*/
        }
    }

    
    public interface IDamagable
    {
        public void Attack(IDamagable target);

        public void TakeDamage(int damage);
    }

    public abstract class Orc : IDamagable
    {
        protected string _name;
        protected int _health;
        protected int _stamina;
        protected int _armor;
        protected int _damage;
        protected int _moveSpeed;
        protected int _position = 0;

        protected Orc(string name, int health, int stamina, int armor, int damage, int moveSpeed)
        {
            _name = name;
            _health = health;
            _stamina = stamina;
            _armor = armor;
            _damage = damage;
            _moveSpeed = moveSpeed;
        }

        public virtual void Attack(IDamagable target)
        {

        }

        public virtual void TakeDamage(int damage)
        {

        }

        public virtual void Print()
        {
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Здоровье: {_health}");
            Console.WriteLine($"Скорость:{_stamina}");
            Console.WriteLine($"Наносимый урон:{_armor}");
            Console.WriteLine($"Броня:{_damage}");
            Console.WriteLine($"Текущая позиция:{_moveSpeed}");
            Console.WriteLine($"Текущая позиция:{_position}");
        }
    }
}