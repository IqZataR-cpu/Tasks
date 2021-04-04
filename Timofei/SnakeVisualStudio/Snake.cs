using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    public class Snake
    {
        private List<Point> _snake;
        private Direction _direction; // направление движения
        
        private Point head; // голова
        private Point tail; // туловище 
        
        private readonly char _snakeSymbol;
        private int step = 1; // скорость
        private int countFruit = 0;
        private bool rotate = true; // поворот
      

        public int CountFruit => countFruit;
        
        enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        public Snake(int x, int y, char symbol, int length)
        {
            _snakeSymbol = symbol;
            _direction = Direction.Right;
            _snake = new List<Point>();

            for (int i = x - length; i < x; i++)
            {
                Point point = (i, y, symbol);
                _snake.Add(point);
                
                Console.ForegroundColor = ConsoleColor.Green;
                point.Draw();
                Console.ResetColor();
            }
        }

        public Point GetNextPoint()
        {
            Point point = GetHead();

            switch (_direction)
            {
                case Direction.Left:
                    point.X -= step;
                    break; 
                case Direction.Right:
                    point.X += step;
                    break;
                case Direction.Up:
                    point.Y -= step;
                    break; 
                case Direction.Down:
                    point.Y += step;
                    break;
            }

            return point;
        }

        public void Rotation(ConsoleKey consoleKey)
        {
            if (rotate)
            {
                switch (_direction)
                {
                    case Direction.Left:
                        case Direction.Right:
                        if (consoleKey == ConsoleKey.DownArrow)
                        {
                            _direction = Direction.Down;
                        }
                        else  if (consoleKey == ConsoleKey.UpArrow)
                        {
                            _direction = Direction.Up;
                        }
                        break;
                    case Direction.Up:
                        case Direction.Down:
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
            }
        }

        public Point GetHead() => _snake.Last();

        public bool IsHitYourSelf(Point yourSelf)
        {
            for (int i = _snake.Count - 2; i > 0; i--)
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
            head = GetNextPoint();

            if (head == foodFactoryFood)
            {
                _snake.Add(head);
                
                Console.ForegroundColor = ConsoleColor.Green;
                head.Draw();
                Console.ResetColor();

                countFruit += 1;
                
                return true;
            }

            return false;
        }

        public void Move()
        {
            head = GetNextPoint();
            
            _snake.Add(head);
            
            tail = _snake.First();
            
            _snake.Remove(tail);
            
            tail.Clear();
            
            Console.ForegroundColor = ConsoleColor.Green;
            head.Draw();
            Console.ResetColor();
            
            rotate = true;
        }
    }
}