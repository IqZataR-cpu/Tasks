using System;
using System.Threading;

namespace Snake
{
    class Game
    {
        private const int _lengthSnake = 3;
        private const int _foodInScore = 40;
        private int _score = 0;
        private int _modificatorScore;
        private int _sizeX;
        private int _sizeY;
        private int _gameDelay;
        private bool _isForWin;
        // Это не количество кадров в секунду, а скорее задержка между кадрами

        private const char WallsSymbol = '#';
        private const char FoodSymbol = '@';
        private const char SnakeSymbol = '*';
        
        private Walls _walls;

        private FoodFactory _foodFactory;

        private Snake _snake;

        private Timer _timer;

        public void Run(int colorWall, int colorFood, int colorSnake, int speedGame, int modificatorScore, int sizeX, int sizeY,bool isForWin)
        {
            _sizeX = sizeX;
            _sizeY = sizeY;
            _gameDelay = speedGame;
            _modificatorScore = modificatorScore;
            _isForWin = isForWin;

            Console.Clear();
            Console.SetWindowSize(_sizeX + 1, _sizeY + 1);
            Console.SetBufferSize(_sizeX + 1, _sizeY + 1);
            Console.CursorVisible = false;
            
            _walls = new Walls(_sizeX, _sizeY, WallsSymbol, colorWall);            

            _snake = new Snake(_sizeX / 2, _sizeY / 2, _lengthSnake, SnakeSymbol, colorSnake);

            _foodFactory = new FoodFactory(_sizeX, _sizeY, FoodSymbol, colorFood);
            _foodFactory.CreateFood();

            // Каждые GameDelay секунд срабатывает метод Loop.
            _timer = new Timer(Loop, null, 0, _gameDelay);
            
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
            if (_walls.IsHitBySnake(_snake.GetHead()) || _snake.IsHitYourSelf(_snake.GetHead()))
            {
                GameOver('l');
                return;
            } 
            else if (_snake.Eat(_foodFactory.Food))
            {
                _score += _foodInScore * _modificatorScore;
                //Это условия для проверки на тестовую победу
                if (_isForWin)
                {
                    if (Snake.isWin(2, 2))
                    {
                        GameOver('w');
                        return;
                    }
                }
                else
                {
                    if (Snake.isWin(_sizeX, _sizeY))
                    {
                        GameOver('w');
                        return;
                    }
                }
                
                _foodFactory.CreateFood();
            } 
            else {
                _snake.Move();
            }
        }

        private void GameOver(char typeOver)
        {
            _timer.Change(0, Timeout.Infinite);
            
            if (typeOver == 'l')
            {
                Console.Clear();
                Console.WriteLine("You are looooooooooooooser!!! " +
                    $"Your score: {_score}\n"
                    );
            }
            else if (typeOver == 'w')
            {
                Console.Clear();
                Console.WriteLine("You are wineeeeer!!! " +
                    $"Your score: {_score}\n"
                    );
            }
        }
    }
}