namespace ObjectOrientiedProgramming.Animals
{
    public class Horse : Animal, IAnimal
    {
        public Horse(int weight, string name) : base(weight, name)
        {
        }

        public void Greetings()
        {
            throw new System.NotImplementedException();
        }

        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }

        public void Idle()
        {
            throw new System.NotImplementedException();
        }
    }
}