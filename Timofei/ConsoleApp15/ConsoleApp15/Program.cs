using System;
using System.Runtime.InteropServices;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dogs = new Dogs("Собака","Бобик", 50, 100);//Непонятно, что за числа ты вводишь в конструктор класса. Вместо 50 и 100 ты мог бы созлать константы dogWeight и dogHealth
            Animal Cats = new Cats("Кот","Барсик", 50, 100);
            Dogs.Print();//Отделяй блок инициализации объектов и блок вызова методов энтером
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

        public int Health => _health; //Эти 4 параметра лучше не разделять Enter-ом, так как они логически связаны. А вообще, не могу понять смысл этого присваивания
        
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
        
        public virtual void Talk() //Если внутри фигурных скобок у тебя ничего нет, ты можешь оформить так: ...Talk() {} 
        {
        }
    }

    public class Dogs : Animal
    {
        public Dogs(string type, string name, int weight, int health) : base(type, name, weight, health) //Если внутри фигурных скобок у тебя ничего нет, ты можешь оформить так: ...health) {} 
        {
        }
        public override void Talk() //Enter между методами
        {
            Console.WriteLine("ГАВ");
        }
    }

    public class Cats : Animal
    {
        public Cats(string type, string name, int weight, int health) : base(type, name, weight, health) //Если внутри фигурных скобок у тебя ничего нет, ты можешь оформить так: ...health) {} 
        {
        }
        public override void Talk() //Enter между методами
        {
            Console.WriteLine("Мяу");
        }
    }
}