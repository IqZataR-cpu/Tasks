using System;

namespace oopEasy
{
    public class Warrior : Orc
    {
        private int maxhealth = 450;
        public Warrior(string name) :
        base(name)
        {
            _health = maxhealth;
            _stamina = 100;
            _armor = 20;
            _damage = 15;
            _moveSpeed = 2;
        }

        public void Moving()
        {
            Console.WriteLine($"Передвигаемся на {_moveSpeed} пунктов");
            _position += _moveSpeed;
        }

        public override void Attack(IDamagable target)
        {
            target.TakeDamage(_damage);
        }

        public override void TakeDamage(int damage)
        {
            _health -= (damage - _armor);
        }

        public void Greet()
        {
            Console.WriteLine("Здравствуй, друг");
        }

        public void Rest()
        {
            if (_health < maxhealth)
            {
                _health += _health / 10;
                if (_health > maxhealth)
                {
                    _health = maxhealth;
                }
            }
            Console.WriteLine($"Вы отдохнули и теперь у вас {_health} здоровья");
        }
    }
}