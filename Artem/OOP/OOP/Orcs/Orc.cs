using System;

namespace OOP.Orcs
{
    abstract class Orc
    {
        protected float health;
        protected int stamina;
        protected readonly float armor;
        protected readonly int damage;
        private int _movementSpeed;
        private int _position = 0;
        protected Orc(int health, int stamina, int armor, int damage, int movementSpeed)
        {
            this.health = health; //В C# использование this не обязательно. Более того, вроде как это является ошибкой
            this.stamina = stamina;
            this.armor = armor;
            this.damage = damage;
            _movementSpeed = movementSpeed;
        }
        public abstract void SayMeetings();
        public abstract void Attack(Orc target);
        public bool IsStaminaEmpty()
        {
            if (stamina == 0)
            {
                return true;
            }

            return false;
        }
        public abstract float TakeDamage(int damage);
        public abstract bool CanApplyDamage(int damage);
        public void MoveForward()
        {
            _position += _movementSpeed;
        }
        public void MoveBack()
        {
            _position -= _movementSpeed;
        }
        public abstract void Rest();
        public virtual void Print()
        {
            Console.WriteLine($"Здоровье: {health}");
            Console.WriteLine($"Выносливость: {stamina}");
            Console.WriteLine($"Броня: {armor}");
            Console.WriteLine($"Атака: {damage}");
            Console.WriteLine($"Скорость: {_movementSpeed}");
            Console.WriteLine($"Позиция: {_position} \n");
        }
        public void VictoryMessage()
        {
            Console.WriteLine("Противник побежден. \n");
        }
    }
}
