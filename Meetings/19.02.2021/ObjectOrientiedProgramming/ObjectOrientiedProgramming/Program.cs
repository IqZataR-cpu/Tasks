using System;
using System.Collections.Generic;
using ObjectOrientiedProgramming.Animals;

namespace ObjectOrientiedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            
            IAnimal animal = new Dog(100 , name);
           
            animal.Greetings();
            animal.PrintHealth();
            animal.Eat();
            animal.PrintHealth();
            animal.Eat();
            animal.PrintHealth();
        }
    }
}