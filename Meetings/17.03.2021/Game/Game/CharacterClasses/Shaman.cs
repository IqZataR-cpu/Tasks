namespace Game.CharacterClasses
{
    public class Shaman : CharacterClass
    {
        private const int Health = 7000;
        private const int AttackDamage = 1500;

        public Shaman() : base(Health, AttackDamage) { }
    }
}