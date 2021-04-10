namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Beretta : Pistol
    {
        public const string NAME = "Beretta";
        public const int DAMAGE = 45;
        public const int AMMUNITION = 7;
        
        public Beretta(string name, int damage, int ammunition) : base(name, damage, ammunition)
        {
        }
    }
}