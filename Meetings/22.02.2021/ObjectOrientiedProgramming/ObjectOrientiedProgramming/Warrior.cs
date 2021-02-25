using System;

namespace ObjectOrientiedProgramming
{
    public class Warrior : Human
    {
        public Warrior(string name, float health, int speed, int attackDamage, int armor) 
            : base(name, health, speed, attackDamage, armor)
        {
            
        }

        public override void Idle()
        {
            throw new NotImplementedException();
        }

        public override void Attack(Human target)
        {
            throw new NotImplementedException();
        }

        public override void TryApplyDamage(int damage)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Класс персонажа - Воин");
        }
    }
}