using System;

namespace OOP.Orcs
{
    class Shaman : Orc
    {
        public Shaman(int health, int stamina, int armor, int damage, int movementSpeed)
            : base(health, stamina, armor, damage, movementSpeed) { }
        public override void SayMeetings()
        {
            Console.WriteLine("Духи не знают усталости \n");
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
            health += 15;
            stamina += 15;
            //Небольшая ошибка: ты можешь отдыхая набить себе хп и стамину до бесконечности. 
            //Я бы сделал некий параметр maxHealth и maxStamina и делал проверку перед добавлением соответствующих параметров.
            //Но это на усмотрение, просто мои мысли.
        }
        public override void Print()
        {
            Console.WriteLine("Класс персонажа: Шаман");
            base.Print();
        }
    }
}
