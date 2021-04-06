namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Gun : Weapon
    {
        public const int DAMAGE = 45;
        public const int AMMUNITION = 7;
        public Gun(string type, int damage, int ammunition) : base(type, DAMAGE, AMMUNITION)
        {
        }

        public override void Reload()
        {
            Ammunition = AMMUNITION;
        }
    }
}