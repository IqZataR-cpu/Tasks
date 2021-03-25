namespace TeamThree.Models
{
    public abstract class Model
    {
        private int _id;
        private string _name;

        protected Model(int id, string name)
        {
            _name = name;
            _id = id;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}