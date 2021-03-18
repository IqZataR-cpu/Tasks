namespace Game.CharacterClasses
{
    public abstract class CharacterClass
    {
        public readonly int Health;
        public readonly int AttackDamage;
        
        protected CharacterClass(int health, int attackDamage)
        {
            Health = health;
            AttackDamage = attackDamage;
        }
    }
}