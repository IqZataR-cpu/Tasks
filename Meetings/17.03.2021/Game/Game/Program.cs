using System;
using System.Collections.Generic;
using Game.CharacterClasses;
using Game.Characters;
using Game.Races;

namespace Game
{
    
    // Домашка
    // 1. Сделать документацию по текущему проекту.
    // 2. Игрок не должен атаковать дружественного НПС.
    // 3. Реализовать оставшиеся методы Приветствие, Движение, Отдых
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Race> races = new Dictionary<string, Race>()
            {
                { "orc", new Orc() },
                { "human", new Human() }
            };

            Race race;
            Console.Write("Введите расу персонажа:");
            string userInput = Console.ReadLine();

            try
            {
                race = races[userInput];
            }
            catch (Exception e)
            {
                race = new Human();
            }

            Character player = new Player(new Shaman(), race);
            Character player1 = new NPC(new Warrior(), race, false);
            player.PrintStates();
            
            player.Attack(player1);
            player1.Attack(player);
            
            player.PrintStates();
            player1.PrintStates();
        }
    }
}