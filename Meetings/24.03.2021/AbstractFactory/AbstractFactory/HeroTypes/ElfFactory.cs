using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.HeroTypes
{
    public class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new Run();
        }

        public override Weapon CreateWeapon()
        {
            return new Knife();
        }
    }
}