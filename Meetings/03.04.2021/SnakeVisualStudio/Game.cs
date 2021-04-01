using System;
using System.Threading;

namespace Snake
{
    class Game
    {
        private const int SizeX = 180;
        private const int SizeY = 10;
        private const int GameDelay = 200; // Это не количество кадров в секунду, а скорее задержка между кадрами

        private const char WallsSymbol = '#';
        private const char FoodSymbol = '@';
        private const char SnakeSymbol = '*';
        
        private Walls _walls;

        private FoodFactory _foodFactory;

        private Snake _snake;

        private Timer _timer;

        public void Run()
        {
            Console.SetWindowSize(SizeX + 1, SizeY + 1);
            Console.SetBufferSize(SizeX + 1, SizeY + 1);
            Console.CursorVisible = false;
            
            _walls = new Walls(SizeX, SizeY, WallsSymbol);
            
            _foodFactory = new FoodFactory(SizeX, SizeY, FoodSymbol);
            _foodFactory.CreateFood();

            _snake = new Snake(SnakeSymbol);
            
            // Каждые GameDelay секунд срабатывает метод Loop.
            _timer = new Timer(Loop, null, 0, GameDelay);
            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    _snake.Rotation(key.Key);
                }
            }
        }
        
        private void Loop (object obj)
        {
            return;

            if (_walls.IsHitBySnake(_snake.GetHead()) || _snake.IsHitYourSelf(_snake.GetHead()))
            {
                _timer.Change(0, Timeout.Infinite);
            } 
            else if (_snake.Eat(_foodFactory.Food))
            {
                _foodFactory.CreateFood();
            } 
            else {
                _snake.Move();
            }
        }
    }
}