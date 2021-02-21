using System;

namespace Practice.Figures
{
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