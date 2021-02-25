using System;

namespace ObjectOrientiedProgramming
{
    public abstract class Human
    {
        protected string _name;
        protected double _health;
        protected int _speed;
        protected double _attackDamage;
        protected double _armor;
        protected int _position = 0;

        public int Position
        {
            get => _position;
        }
        
        protected Human(string name, double health, int speed, double attackDamage, double armor)
        {
            _name = name;
            _health = health;
            _speed = speed;
            _attackDamage = attackDamage;
            _armor = armor;
        }

        public abstract void Idle();
        
        public abstract void Attack(Human target);

        // хп не должно уйти в отрицательное значение

        public void MoveForward()
        {
            _position += _speed;
        }

        public void MoveBack()
        {
            _position -= _speed;
        }
        
        public virtual void Print()
        {
            Console.WriteLine($"Имя: {_name}");
            Console.WriteLine($"Здоровье: {_health}");
            Console.WriteLine($"Скорость:{_speed}");
            Console.WriteLine($"Наносимый урон:{_attackDamage}");
            Console.WriteLine($"Броня:{_armor}");
            Console.WriteLine($"Текущая позиция:{_position}");
        }
    }
}