using System;
using Practice.Figures;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle("Треугольник", 4, 2, 5);
            Tetragon tetragon = new Tetragon("Четырехугольник", 2, 3, 4, 5);
            
            triangle.Print();
            tetragon.Print();
            
            Console.WriteLine($"Площадь треугольника:{triangle.Area2}");
            Console.WriteLine($"Площадь четырехугольника:{tetragon.Area2}");
        }
    }
    // Задача на полиморфизм подтипов,
    // Реализовать методы Print и Area(Площадь) и свойство Area2 - пример свойства - Name
    // для подтипов Triangle и Tetragon(четырехугольник)
    public abstract class Figure
    {
        private string _name;

        protected Figure(string name)
        {
            _name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public abstract double Area2 { get; }

        public abstract double Area();

        public virtual void Print()
        {
            Console.WriteLine($"name = {Name}");
        }
    }
}
//Миша пидр