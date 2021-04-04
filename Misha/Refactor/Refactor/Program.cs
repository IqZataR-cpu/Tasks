using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            
            game.Run();
        }
    }

    public class Game
    {
        private readonly string[] _options = {"Rock", "Paper", "Scissor"};
        private readonly string[] _gameResult = {"User win!", "Comp win!", "It's draw!"};
        
        // evil practice for maintaining the code
        private readonly int[,] _resultsMatrix = 
        {
            {2, 0, 1},
            {1, 2, 0},
            {0, 1, 2},
        };

        public void Run()
        {
            Random random = new Random();
            
            while (true)
            {
                int gameChoice = random.Next(0, _options.Length);

                Play(MakeUserChoice(), gameChoice);
            }
        }
        
        private void Play(int userChoice, int gameChoice)
        {
            Console.WriteLine(
                _gameResult[
                    _resultsMatrix[
                        gameChoice,
                        userChoice
                    ]
                ]
            );
        }

        private int MakeUserChoice()
        {
            while (true)
            {
                PrintUserOptions();
                
                Console.WriteLine("Your choice:");
                var userInput = Console.ReadLine();
                
                if (IsInputValid(userInput))
                {
                    try
                    {
                        return int.Parse(userInput) - 1;
                    }
                    catch (Exception e)
                    {
                        return Array.IndexOf(_options, userInput);
                    }
                }
                
                Console.WriteLine("You must enter a valid choice.");
            }
        }

        private void PrintUserOptions()
        {
            Console.WriteLine("Please enter one of the following words:");

            foreach ((string item, int index) in WithIndex(_options))
            {
                Console.WriteLine($"{index + 1} - \"{item}\"");
            }
        }

        private bool IsInputValid(string userInput)
        {
            return userInput != null 
                   && _options.Contains(userInput) 
                   || ArrayContainsKey(_options, int.Parse(userInput) - 1);
        }
        
        private static IEnumerable<(T item, int index)> WithIndex<T>(IEnumerable<T> source)
        {
            return source.Select((item, index) => (item, index));
        }

        private bool ArrayContainsKey(Array array, int key)
        {
            return key > -1 && key < array.Length;
        }
    }
}