namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public abstract class Weapon
    {
        private string _type;
        private int _damage;
        private int _ammunition;

        public string Type => _type;

        public int Damage => _damage;

        public int Ammunition
        {
            get => _ammunition;
            set => _ammunition = value;
        }
        
        public Weapon(string type, int damage, int ammunition)
        {
            _type = type;
            _damage = damage;
            _ammunition = ammunition;
        }

        public abstract void Reload();
    }
}