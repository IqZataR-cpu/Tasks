using System;

namespace oopEasy
{
    public class Shaman : Orc
    {
        private int maxhealth = 300;
        public Shaman(string name) :
            base(name)
        {
            _health = maxhealth;
            _stamina = 150;
            _armor = 10;
            _damage = 30;
            _moveSpeed = 3;
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