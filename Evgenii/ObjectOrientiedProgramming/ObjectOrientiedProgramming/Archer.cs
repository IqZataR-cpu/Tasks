using System;

namespace ObjectOrientiedProgramming
{
    
    public class Archer : Human
    {
        private const int idleHeal = 25;
        public Archer(string name, float health, int speed, int attackDamage, int armor) 
            : base(name, health, speed, attackDamage, armor)
        {
            
        }

        public override void Idle()
        {
            _health += idleHeal;
        }

        public override void Attack(Human target)
        {
            if (_health > 0)
            {
                _health -= (damage - _armor * 0.1);
            }
        }


        public override void Print()
        {
            base.Print();
            Console.WriteLine("Класс персонажа - Лучник");
        }
    }
}