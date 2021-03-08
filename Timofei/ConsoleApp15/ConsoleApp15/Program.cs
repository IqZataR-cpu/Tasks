using System;
using System.Runtime.InteropServices;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dogs = new Dogs("Собака","Бобик", 50, 100);
            Animal Cats = new Cats("Кот","Барсик", 50, 100);
            Dogs.Print();
            Dogs.Talk();
        }   
    }

    public class Animal
    {
        private string _type;
        private string _name;
        private int _weight;
        private int _health;

        public string Type => _type;

        public string Name => _name;

        public int Weight => _weight;

        public int Health => _health;
        
        protected Animal(string type, string name, int weight, int health)
        {
            _type = type;
            _name = name;
            _weight = weight;
            _health = health;
        }

        public virtual void Print()
        {
            Console.WriteLine($"{_type}");
            Console.WriteLine($"Кличка - {_name}");
            Console.WriteLine($"Вес - {_weight}");
            Console.WriteLine($"Здоровье - {_health}");
        }
        
        public virtual void Talk()
        {
        }
    }

    public class Dogs : Animal
    {
        public Dogs(string type, string name, int weight, int health) : base(type, name, weight, health)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("ГАВ");
        }
    }

    public class Cats : Animal
    {
        public Cats(string type, string name, int weight, int health) : base(type, name, weight, health)
        {
        }
        public override void Talk()
        {
            Console.WriteLine("Мяу");
        }
    }
}