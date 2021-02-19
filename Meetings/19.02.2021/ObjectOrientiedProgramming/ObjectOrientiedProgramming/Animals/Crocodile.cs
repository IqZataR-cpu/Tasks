namespace ObjectOrientiedProgramming.Animals
{
    public class Crocodile : Animal, IAnimal
    {
        public Crocodile(int weight, string name) : base(weight, name)
        {
        }
        
        public virtual void Greetings() { }
        
        public virtual void Eat() { }

        public virtual void Run() { }

        public virtual void Idle() { }
    }
}