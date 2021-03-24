using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.HeroTypes
{
    public class DragonFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new Fly();
        }

        public override Weapon CreateWeapon()
        {
            return new Riffle();
        }
    }
}