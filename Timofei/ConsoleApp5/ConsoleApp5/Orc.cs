using System;
namespace ConsoleApp5
{
    public abstract class Orc
    {
        private float _health;
        private int   _stamina;
        private int   _armor;
        private int   _attackDamage;
        private int   _speed;
        private int   _position;
        private string _orcType;

        protected Orc(float health, int stamina, int armor, int attackDamage,int speed, int position, String orcType)
        {
            _health = health;
            _stamina = stamina;
            _armor = armor;
            _attackDamage = attackDamage;
            _speed = speed;
            _position = position;
            _orcType = orcType;
        }

      

        public float Health
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
        }
        public int AttackDamage
        {
            get => _attackDamage;
        }
        public int Speed
        {
            get => _speed;
        }

        public int Position
        {
            get => _position;
            set => _position = value;
        }

        public string OrcType => _orcType;

        public abstract void Idle();
        public abstract void PlusStamina();
        public abstract void MinusStamina();
        public abstract void Attack(Orc target);
        
        public abstract void TryApplayDamage(int damage);
        public abstract void MoveForvard();
        public abstract void MoveBack();
        
        public virtual void Print()
        {
            Console.WriteLine($"Здоровье: {_health}");
            Console.WriteLine($"Выносливость: {_stamina}");
            Console.WriteLine($"Защита: {_armor}");
            Console.WriteLine($"Атака: {_attackDamage}");
            Console.WriteLine($"Скорость: {_speed}");
            Console.WriteLine($"Местоположение: {_position}");
            Console.WriteLine($"Класс: {_orcType}");
        }
    }
    
   
    
        
    
}
  
