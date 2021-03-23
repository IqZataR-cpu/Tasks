namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public abstract class Weapon
    {
        private int _damage;
        private int _ammunition;

        protected Weapon(int damage, int ammunition)
        {
            _damage = damage;
            _ammunition = ammunition;
        }
        
        protected Weapon(int damage)
        {
            _damage = damage;
        }
    }
}