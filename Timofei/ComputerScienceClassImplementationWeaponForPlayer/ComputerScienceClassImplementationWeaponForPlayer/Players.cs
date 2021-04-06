namespace ComputerScienceClassImplementationWeaponForPlayer
{
    public class Players
    {
        private string _name;
        private int _health;
        private Weapon _weapon;

        public string Name => _name;

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public Weapon Weapon
        {
            get => _weapon;
            set => _weapon = value;
        }

        protected Players(string name, int health, Weapon weapon)
        {
            _name = name;
            _health = health;
            _weapon = weapon;
        }
    }
}