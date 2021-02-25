using System;

namespace ConsoleApp5
{
    public class Shaman : Orc
    {
        public const int MAX_HEALTH = 100;
        public const int MAX_STAMINA = 110;
        public const int STEP_POSITION = 25;
        public const int STAMINA_FOR_ATTACK = 50;
        // Не полное название, мне кажется нужно было уточнить,
        // что такое количество здоровья восстанавливается при именно при отдыхе
        // RESTORE_HEALTH_WHEN_IDLE = 35;
        public const int RESTORE_HEALTH = 35;
        public const int RESTORE_STAMINA = 40;
        
        
        // Нет смысла пробрасывать Орк type таким образом,
        // логичнее было бы сделать константу в этом классе и засунуть ее в параметр базового класса
        // private const string TYPE = "ВОИН";
        //  public Shaman(float health, int stamina, int armor, int attackDamage, int speed, int position)
        //      : base(health, stamina, armor, attackDamage, speed, position, TYPE)
        public Shaman(float health, int stamina, int armor, int attackDamage, int speed, int position, string orcType)
            : base(health, stamina, armor, attackDamage, speed, position, orcType)
        {
        }
        

        public override void Idle()
        {
            Health += RESTORE_HEALTH;
            PlusStamina();

            // Знаки сравнения выделяем запятыми с двух сторон и вообще в целом все знаки операций.
            if (Health>MAX_HEALTH)
            {
                Health = MAX_HEALTH;
            }
            
            // Знаки сравнения выделяем запятыми с двух сторон и вообще в целом все знаки операций.
            if (Stamina>MAX_STAMINA)
            {
                Stamina = MAX_STAMINA;
            }
        }

        // Лучше пробрасывать восстанавливаемое значение через параметр метода
        // PlusStamina(RESTORE_STAMINA);
        // public override void PlusStamina(int value) { Stamina += value; }
        public override void PlusStamina()
        {
          
            Stamina += RESTORE_STAMINA;
                
        }

        // Аналог выше, это позволяет переиспользовать метод для разных назначений
        // К примеру нам нужно убавлять стамину, когда мы движемся,
        // тогда константа здесь будет не уместна
        // или нужен будет второй метод с другой константой,
        // что порождает дубляж кода
        public override void MinusStamina()
        {
            Stamina -= STAMINA_FOR_ATTACK;
        }

        // Если мы однозначно не можем сказать,
        // что мы 100% атакуем, то называем метод с префиксом Try 
        // Поскольку у нас есть условие, которое говорит нам,
        // что мы не можем атаковать, если у нас мало стамины,
        // то мы не всегда атакуем, следовательно нужно сделать TryAttack
        public override void Attack(Orc target)
        {
            // То есть если у нас 49 стамины и мы пробуем атаковать,
            // то у нас стамины становится 0 и мы получаем сообщение о том,
            // что нам нужно ее восстановить,
            // при этом мы ее никуда не потратиили, почему ее становится 0 - непонятно!
            // Видимо, мы ее потратили, чтобы вывести сообщения в консоль,
            // тяжелые нынче консоли пошли, могут до 49 стамины сжирать, ЗА РАЗ!!!
            // бесполезный ход получается, который просто обнуляет стамину,
            // если ты так и задумывал, то без проблем, но если нет - пофикси.
            if (Stamina < STAMINA_FOR_ATTACK)
            {
                Stamina = 0;
                Console.WriteLine($"Шаман! Восстанови энергию!");
            }
            else
            {
                target.TryApplayDamage(AttackDamage);
                MinusStamina();
            }
        }

        // ПРавильное английское слово Apply, не Applay
        public override void TryApplayDamage(int damage)
        {
            // Знаки сравнения выделяем запятыми с двух сторон и вообще в целом все знаки операций.
            if (Health<=damage-(Armor/5))
            {
                Health = 0;
                Console.WriteLine($"Герой Шаман. Погиб.");
            }
            else
            {
                // Знаки сравнения выделяем запятыми с двух сторон и вообще в целом все знаки операций.
                Health -= damage-(Armor/5);
            }
        }

        // Правильное английское слово forward, не forvard,
        // зачем тогда нам поле класса speed, если мы скорость константой задаем?
        public override void MoveForvard()
        {
            Position += STEP_POSITION;
        }

        // зачем тогда нам поле класса speed, если мы скорость константой задаем?
        public override void MoveBack()
        {
            Position -= STEP_POSITION;
        }
    }
}