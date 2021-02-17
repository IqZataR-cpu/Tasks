using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrintiedProgramming.Mobs;

namespace ObjectOrintiedProgramming
{
    class Program
    {
        private static Dictionary<string, Orc> OrcTypes = new Dictionary<string, Orc>()
        {
            {"Shaman", new Shaman(100, 10)},
            {"Warrior", new Warrior(200, 5)},
        };
        
        static void Main(string[] args)
        {
            while (true)
            {
                if (OrcTypes.Count <= 0) continue;
                
                Console.WriteLine($"Выберите тип Орка:{GetOrcTypes()}");
                IGreetingsContract hero = MakeOrc(Console.ReadLine());

                hero.SayGreetings();
            }
        }

        static IGreetingsContract MakeOrc(string input)
        {
            if (OrcTypes.ContainsKey(input))
                return OrcTypes[input];

            return new Orc(0, 0);
        }

        static string GetOrcTypes()
        {
            return OrcTypes.Aggregate(
                "", (result, item) => result + item.Key + ", "
                ).Trim().Trim(',');

            // Аналог того, что написано выше
            string result = "";
            
            foreach (var item in OrcTypes)
            {
                result += item.Key + ", ";
            }

            // очищает лишние символы из конца строки
            return result.Trim().Trim(',');
        }
    }
}