using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.HeroTypes
{
    public class HumanFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new Run();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}