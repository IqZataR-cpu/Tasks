using System;
using AbstractFactory.HeroTypes;
using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory
{
    class Hero
    {
        private Weapon _weapon;
        private Movement _movement;
        
        public Hero(HeroFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }

        public void Move()
        {
            _movement.Move();
        }

        public void Hit()
        {
            _weapon.Hit();
        }
    }
}