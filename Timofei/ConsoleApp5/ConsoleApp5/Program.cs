using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Orc shaman = new Shaman(120, 110, 70, 25, 25, 0, "Шаман");
            Orc warrior = new Warrior (200,100,100,15,20, 0, "Воин");
            Orc hunter = new Hunter(100,140,50,35,30,0, "Охотник");
            
            shaman.Print();
            Console.WriteLine($"___________________");
            warrior.Print();
            Console.WriteLine($"___________________");
            hunter.Print();
            
            Console.WriteLine($"___________________");
            Console.WriteLine($"___________________");
            Console.WriteLine($"___________________");
    
            Console.WriteLine($"Ход 1. Шаман Атакует Охотника");
            shaman.Attack(hunter);
            shaman.Attack(hunter);
            shaman.Attack(hunter);
            shaman.Attack(hunter);
            shaman.Attack(hunter);
            shaman.Attack(hunter);
            hunter.Print();
            Console.WriteLine($"___________________");
            shaman.Print();
            shaman.MoveForvard();
            warrior.MoveForvard();
            hunter.MoveForvard();
            
            Console.WriteLine($"Ход 2. Охотник Атакует Шамана");
            hunter.Attack(shaman);
            hunter.Print();
            Console.WriteLine($"___________________");
            shaman.Print();
            shaman.MoveForvard();
            warrior.MoveForvard();
            hunter.MoveForvard();
            
            Console.WriteLine($"Ход 3. Воин Атакует Шамана");
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            warrior.Attack(shaman);
            hunter.Idle();
            hunter.Idle();
            hunter.Idle();
            hunter.Print();
            Console.WriteLine($"___________________");
            shaman.Print();
            Console.WriteLine($"___________________");
            warrior.Print();
            shaman.MoveBack();
            warrior.MoveForvard();
            hunter.MoveForvard();
        }
       
    }
}