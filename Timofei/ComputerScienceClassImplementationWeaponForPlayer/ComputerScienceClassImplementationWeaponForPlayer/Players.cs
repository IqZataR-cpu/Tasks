namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Players
    {
        private string _name;
        private int _health;
        private string _weapon;
        private int _damage;
        private int _ammunition;

        public string Name => _name;

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public string Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }

        public int Damage
        {
            get => _damage;
            set => _damage = value;
        }

        public int Ammunition
        {
            get => _ammunition;
            set => _ammunition = value;
        }

        protected Players(string name, int health, string weapon, int damage, int ammunition)
        {
            _name = name;
            _health = health;
            _weapon = weapon;
            _damage = damage;
            _ammunition = ammunition;
        }
    }
}