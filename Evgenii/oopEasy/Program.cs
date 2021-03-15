namespace oopEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Shaman Trall = new Shaman("Trall");
            Hunter Recsar = new Hunter("Recsar");
            Warrior Garrosh = new Warrior("Garrosh");
            Trall.Print();
            Trall.Greet();
            Trall.Moving();
            Trall.Attack(Garrosh);
            Trall.Rest();

            Recsar.Print();
            Recsar.Greet();
            Recsar.Moving();
            Recsar.Attack(Trall);
            Recsar.Rest();

            Garrosh.Print();
            Garrosh.Greet();
            Garrosh.Moving();
            Garrosh.Attack(Recsar);
            Garrosh.Rest();

            Trall.Print();
            Recsar.Print();
            Garrosh.Print();
        }
    }

    
    public interface IDamagable
    {
        public void Attack(IDamagable target);

        public void TakeDamage(int damage);
    }
}