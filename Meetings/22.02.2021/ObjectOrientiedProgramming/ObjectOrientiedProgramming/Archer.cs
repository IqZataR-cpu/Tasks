namespace ObjectOrientiedProgramming
{
    public class Archer : Human
    {
        public Archer(string name, float health, int speed, int attackDamage, int armor) 
            : base(name, health, speed, attackDamage, armor)
        {
            
        }

        public override void Idle()
        {
            throw new System.NotImplementedException();
        }

        public override void Attack(Human target)
        {
            throw new System.NotImplementedException();
        }

        public override void TryApplyDamage(int damage)
        {
            throw new System.NotImplementedException();
        }
    }
}