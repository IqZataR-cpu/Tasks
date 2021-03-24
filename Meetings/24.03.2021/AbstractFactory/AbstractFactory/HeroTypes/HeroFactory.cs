using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.HeroTypes
{
    public abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        
        public abstract Weapon CreateWeapon();
    }
}