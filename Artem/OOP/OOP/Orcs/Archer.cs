using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Orcs
{
    class Archer : Orc
    {
        public Archer(int health, int stamina, int armor, int damage, int movementSpeed)
           : base(health, stamina, armor, damage, movementSpeed) { }
        public override void SayMeetings()
        {
            Console.WriteLine("Зак зак \n");
        }
        public override void Attack(Orc target)
        {
            if (IsStaminaEmpty())
            {
                Console.WriteLine("Вы устали и не можете атаковать. Отдохните. \n");
                return;
            }
            target.TakeDamage(damage);
            stamina -= 20;
        }
        public override float TakeDamage(int damage)
        {
            if (CanApplyDamage(damage))
            {
                VictoryMessage();
                return health = 0;
            }

            return health -= damage - (armor / 10);
        }
        public override bool CanApplyDamage(int damage)
        {
            if (health <= damage - (armor / 10))
            {
                return true;
            }

            return false;
        }
        public override void Rest()
        {
            health += 10;
            stamina += 20;
        }
        public override void Print()
        {
            Console.WriteLine("Класс персонажа: Лучник");
            base.Print();
        }
    }
}
