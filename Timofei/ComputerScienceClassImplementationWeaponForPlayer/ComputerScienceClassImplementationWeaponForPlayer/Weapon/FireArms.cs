namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class FireArms : Weapon
    {
        public FireArms(string name, int damage, int ammunition) : base(name, damage, ammunition)
        {
        }
        
        public override void ReloadAmmo()
        {
        }
    }
}