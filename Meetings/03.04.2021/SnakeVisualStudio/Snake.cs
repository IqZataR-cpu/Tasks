using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Snake
    {
        private static List<Point> _snake;
        private Point _head;
        private Point _tail;
        private Direction _direction;
        private char _symbol;
        private const int _step = 1;
        private bool _isRotate = true;
        private int _color;
        
        enum Direction 
        {
            Left,
            Right,
            Up,
            Down
        }
        
        public Snake(int x, int y, int length, char symbol, int color)
        {
            _direction = Direction.Right;
            _snake = new List<Point>();
            _symbol = symbol;
            _color = color;        

            for (int i = x - length; i < x; i++)
            {
                Point snake = (i, y, symbol);
                _snake.Add(snake);
                snake.Draw(color);
            }
        }
        
        public void Rotation(ConsoleKey consoleKey)
        {
            if (_isRotate)
            {
                switch (_direction)
                {
                    case Direction.Right:
                    case Direction.Left:
                        if (consoleKey == ConsoleKey.UpArrow)
                        {
                            _direction = Direction.Up;
                        }
                        else if (consoleKey == ConsoleKey.DownArrow)
                        {
                            _direction = Direction.Down;
                        }
                        break;
                    case Direction.Down:
                    case Direction.Up:
                        if (consoleKey == ConsoleKey.LeftArrow)
                        {
                            _direction = Direction.Left;
                        }
                        else if (consoleKey == ConsoleKey.RightArrow)
                        {
                            _direction = Direction.Right;
                        }
                        break;
                }

                _isRotate = false;
            }
        }

        public Point GetHead() => _snake.Last();

        public bool IsHitYourSelf(Point yourSelf)
        {
            for (int i = _snake.Count - 2; i >= 0; i--)
            {
                if (_snake[i] == yourSelf)
                {
                    return true;
                }
            }

            return false;
        }

        public bool Eat(Point foodFactoryFood)
        {
            _head = GetNextPoint();

            if (_head == foodFactoryFood)
            {
                _snake.Add(_head);
                _head.Draw(_color);

                return true;
            }

            return false;
        }

        public void Move()
        {
            _head = GetNextPoint();
            _snake.Add(_head);
            _tail = _snake.First();
            _snake.Remove(_tail);
            _tail.Clear(_color);
            _head.Draw(_color);
            _isRotate = true;
        }

        private Point GetNextPoint()
        {
            Point snake = GetHead();

            switch (_direction)
            {
                case Direction.Left:
                    snake.X -= _step;
                    break;
                case Direction.Right:
                    snake.X += _step;
                    break;
                case Direction.Up:
                    snake.Y -= _step;
                    break;
                case Direction.Down:
                    snake.Y += _step;
                    break;
            }

            return snake;
        }

        public static bool isFoodOnSnake(Point Food)
        {
            for (int i = _snake.Count - 1; i >= 0; i--)
            {
                if (_snake[i] == Food)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool isWin(int sizeFieldX, int sizeFieldY)
        {
            return _snake.Count == sizeFieldX * sizeFieldY;
        }
    }
}