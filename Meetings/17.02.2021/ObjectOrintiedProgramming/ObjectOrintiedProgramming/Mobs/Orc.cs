using System;

namespace ObjectOrintiedProgramming.Mobs
{
    public class Orc : IGreetingsContract
    {
        private int _health;
        private int _damage;

        public bool isAlive => _health > 0;
        
        
        public Orc(int health = 100, int damage = 100)
        {
            _health = health;
            _damage = damage;
        }

        public virtual void SayGreetings()
        {
            Console.WriteLine("AGGGRRH");
        }
        
        public void TryApplyDamage(int damage)
        {
            if (CanTakeDamage(damage))
            {
                _health -= damage;
            }
        }

        public int GetDamage()
        {
            return _damage;
        }

        public void PrintStats()
        {
            PrintHealth();
            PrintDamage();
        }

        public void PrintHealth()
        {
            Console.WriteLine($"Здоровье:{_health.ToString()}");
        }

        public void PrintDamage()
        {
            Console.WriteLine($"Атака:{_damage.ToString()}");
        }

        private bool CanTakeDamage(int damage)
        {
            return _health > damage;
        }
    }
}