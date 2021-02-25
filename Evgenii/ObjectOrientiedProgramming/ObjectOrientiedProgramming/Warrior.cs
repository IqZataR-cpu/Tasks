using System;

namespace ObjectOrientiedProgramming
{
    public class Warrior : Human
    {
        private const int idleHeal = 25;
        public Warrior(string name, double health, int speed, double attackDamage, double armor) 
            : base(name, health, speed, attackDamage, armor)
        {
            
        }

        public override void Idle()
        {
            _health += idleHeal;
        }

        public override void Attack(Human target)
        {
            TryApplyDamage(target.coef);
        }
        
        public void TryApplyDamage(float coef)
        {
            if (target._health > 0)
            {
                target._health -= (damage - target._armor * coef);
            }
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Класс персонажа - Воин");
        }
    }
}