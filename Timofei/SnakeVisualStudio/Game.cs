using System;
using System.Threading;

namespace Snake
{
    public class Game
    {
        private const int SizeX = 50;
        private const int SizeY = 10;
        private const int GameDelay = 200; // Это не количество кадров в секунду, а скорее задержка между кадрами
        private const int SnakeLength = 3; 
        
        private const char WallsSymbol = '#';
        private const char FoodSymbol = '@';
        private const char SnakeSymbol = '0';
        
        private Walls _walls;

        private FoodFactory _foodFactory;

        private Snake _snake;

        private Timer _timer;
        
        public void Run()
        {
            Console.SetWindowSize(SizeX + 1, SizeY + 1);
            Console.SetBufferSize(SizeX + 1, SizeY + 1);
            Console.CursorVisible = false;
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            _walls = new Walls(SizeX, SizeY, WallsSymbol);
            Console.ResetColor();
            
            _foodFactory = new FoodFactory(SizeX, SizeY, FoodSymbol);
            _foodFactory.CreateFood();
            
            _snake = new Snake(SizeX / 2, SizeY / 2, SnakeSymbol, SnakeLength);
            
            // Каждые GameDelay секунд срабатывает метод Loop.
            _timer = new Timer(Loop, null, 0, GameDelay);
           
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    _snake.Rotation(key.Key);
                }
            }
        }
        
        private void Loop (object obj)
        { 
            if (_walls.IsHitBySnake(_snake.GetHead()) || _snake.IsHitYourSelf(_snake.GetHead()))
            {
                _timer.Dispose();
                
                PrintLose();
            } 
            else if (_snake.Eat(_foodFactory.Food))
            {
                
                _foodFactory.CreateFood();
            } 
            else 
            {
                if (_snake.CountFruit == 10)
                {
                    PrintWin();
                }
                else
                {
                    _snake.Move();
                }
            }
        }

        private void PrintLose()
        {
            Console.Clear();
            Console.WriteLine("Ты проиграл.");
            Console.WriteLine($"Собрано фруктов {_snake.CountFruit}.");
            Console.WriteLine($"Получено очков {_snake.CountFruit * 10}.");
            Console.WriteLine("");
            
            Program.Main();
        }
        private void PrintWin()
        {
            Console.Clear();
            Console.WriteLine("Ты победил.");
            Console.WriteLine($"Собрано фруктов {_snake.CountFruit}.");
            Console.WriteLine($"Получено очков {_snake.CountFruit * 10}.");
            Console.WriteLine("");
            
            Program.Main();
        }
    }
}