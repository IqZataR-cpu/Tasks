using System;

namespace ConsoleApp5
{
    // Для первого раза - КРУТО!
    // Но есть очень много мелких и не очень недочетов,
    // все классы не проверял, посмотрел только Orc и Shaman,
    // но замечания везде примерно одного и того же уровня.
    // Очень боевой код с которым можно работать, но его нужно немного подпилить.
    // Продолжай в том же духе и будет все шикарно!
    class Program
    {
        static void Main(string[] args)
        {
            // Ставим пробел после запятой в перечислении параметров!
            Orc shaman = new Shaman(120, 110, 70, 25, 25, 0, "Шаман");
            Orc warrior = new Warrior (200,100,100,15,20, 0, "Воин");
            Orc hunter = new Hunter(100,140,50,35,30,0, "Охотник");
            
            shaman.Print();
            // Логично было бы сделать функцию которая печатает Разделитель 
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
            // Если так захотелось сделать 14 атак, сделал бы цикл,
            // не влияет на производительность, но улучшает читабельность
            // for (int i = 0; i < 14; i++) warrior.Attack(shaman)
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
        // Непонятный Enter тут, для чего?
       
    }
    
    // Пример функции печатающей разделитель, вместо дубляжа кода
    private static void PrintSeparator()
    {
        Console.WriteLine($"___________________");
    }
}