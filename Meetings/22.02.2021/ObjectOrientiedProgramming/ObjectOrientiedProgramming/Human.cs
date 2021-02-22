using System;

namespace ObjectOrientiedProgramming
{
    public abstract class Human
    {
        private string _name;
        private float _health;
        private int _speed;
        private int _attackDamage;
        private int _armor;
        private int _position = 0;

        public int Position
        {
            get => _position;
        }
        
        protected Human(string name, float health, int speed, int attackDamage, int armor)
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
        public abstract void TryApplyDamage(int damage);

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