namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Knife : Weapon
    {
        public Knife(string type, int damage, int ammunition) : base(type, damage, ammunition)
        {
        }

        public override void Reload()
        {
            throw new System.NotImplementedException();
        }
    }
}