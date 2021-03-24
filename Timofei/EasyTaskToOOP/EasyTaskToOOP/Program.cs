using System;

namespace EasyTaskToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
           Orc firstPlayer = new Warrior("Тимофей", 100, 100, 100,
                35, 45, 0);
           Orc secondPlayer = new Hunter("Михаил", 100, 100, 70,
               35, 50, 0);
           
            firstPlayer.Print();
            Console.WriteLine();
            secondPlayer.Print();

            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            
            firstPlayer.Idle();
            Console.WriteLine();
            
            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            
            firstPlayer.Idle();
            Console.WriteLine();
            
            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            
            firstPlayer.Idle();
            Console.WriteLine();
            
            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            
            firstPlayer.Attack(secondPlayer);
            Console.WriteLine();
            
            firstPlayer.MovementBack();
        }
    }

    class Orc
    {
        public const int STAMINA_TO_ATTACK = 30;
        public const int STEP = 30;
        
        private string _name;
        private int _health;
        private int _stamina;
        private int _armor;
        private int _attackDamage;
        private int _speedRun;
        private double _position;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public int Stamina
        {
            get => _stamina;
            set => _stamina = value;
        }

        public int Armor
        {
            get => _armor;
            set => _armor = value;
        }

        public int AttackDamage
        {
            get => _attackDamage;
            set => _attackDamage = value;
        }

        public int SpeedRun
        {
            get => _speedRun;
            set => _speedRun = value;
        }

        public double Position
        {
            get => _position;
            set => _position = value;
        }

        public Orc(string name, int health, int stamina, int armor, int attackDamage, int speedRun, double position)
        {
            _name = name;
            _health = health;
            _stamina = stamina;
            _armor = armor;
            _attackDamage = attackDamage;
            _speedRun = speedRun;
            _position = position;
        }

        public void Greeting(Orc target)
        {
            Console.WriteLine($"\n Игрок {Name}, приветствует игрока {target._name}");
        }

        public void Attack(Orc target)
        {
            if (target.Health == 0)
            {
                Console.WriteLine($"Вы не можете атаковать игрока {target.Name}");
            }
            else
            { 
                if (Stamina < STAMINA_TO_ATTACK)
                {
                    Console.WriteLine($"{Name}, вашему герою необходимо отдохнуть! \n");
                }
                else
                {
                    Console.WriteLine($"Игрок {Name}, атаковал игрока {target.Name} \n");
                    
                    Stamina -= STAMINA_TO_ATTACK;
                    
                    target.TryApplyDamage(AttackDamage);
                }
            }
            
            Print();
        }

        public void TryApplyDamage(int attackDamage)
        {
            if (Health < attackDamage - Armor / 5)
            {
                Console.WriteLine($"\n Игрок {Name} погиб. \n");
                Health = 0;
            }
            else
            {
                Health -= (attackDamage - Armor / 5);
            }
            
            Print();
        }

        public void MovementBack()
        {
            Position -= STEP;
            
            Print();
        }
        
        public void MovementForward()
        {
            Position += STEP;
            
            Print();
        }
        
        public void Idle()
        {
            if (Stamina > 100)
            {
                Stamina = 100;
            }
            else
            {
                Stamina += 20;
            }
            
            if (Health >= 100)
            {
                Health = 100;
            }
            else
            {
                Health += 35;
            }
            
            Print();
        }

        public void Print()
        {
            Console.WriteLine($"{Name} \n" +
                              $"Твои характеристики: \n" +
                              $"Здоровье: {Health} \n" +
                              $"Выносливость: {Stamina} \n" +
                              $"Защита: {Armor} \n" +
                              $"Урон: {AttackDamage} \n" +
                              $"Скорость передвижения: {SpeedRun} \n" +
                              $"Позиция: {Position} \n");
        }
    }

    class Shaman : Orc
    {
        public Shaman(string name, int health, int stamina, int armor, int attackDamage, int speedRun, double position)
            : base(name, health, stamina, armor, attackDamage, speedRun, position)
        {
        }
    }
    
    class Warrior : Orc
    {
        public Warrior(string name, int health, int stamina, int armor, int attackDamage, int speedRun, double position) 
            : base(name, health, stamina, armor, attackDamage, speedRun, position)
        {
        }
    }
    
    class Hunter : Orc
    {
        public Hunter(string name, int health, int stamina, int armor, int attackDamage, int speedRun, double position) 
            : base(name, health, stamina, armor, attackDamage, speedRun, position)
        {
        }
    }
}