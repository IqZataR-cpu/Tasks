namespace Game.CharacterClasses
{
    public class Warrior : CharacterClass
    {
        public const int Health = 10000;
        private const int AttackDamage = 1500;

        public Warrior() : base(Health, AttackDamage) { }
    }
}