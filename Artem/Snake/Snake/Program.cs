using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake
{
	class Program
	{
		public static Snake snake;
		public static Food food;
		public static Map map;
		public static Timer time;
		
		public static void Main(string[] args)
		{
			const int x = 80;
			const int y = 26;
			

			Console.SetWindowSize(x + 20, y + 20);
			Console.SetBufferSize(x + 20, y + 20);
			Console.CursorVisible = false;

			snake = new Snake(x / 2, y / 2, 3);
			food = new Food(x, y);
			map = new Map(x, y);
			Console.WriteLine();

			time = new Timer(Loop, null, 0, 200);

			 while(true)
            {
				if (Console.KeyAvailable)
                {
					ConsoleKeyInfo key = Console.ReadKey();
					snake.Turning(key.Key);
                }
             }
		}

		public static void Loop(object obj)
		{
            if (map.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
            {
                time.Change(0, Timeout.Infinite);
            }
            else if (snake.IsEating(food))
            {
                food.FoodRender();
            }
            else if (snake.IsWin())
            {
                time.Change(0, Timeout.Infinite);
                Console.WriteLine("You are win!!!");
            }
            else
            {
				snake.Move();
            }
        }
    }

	public class Point
	{
		public int X;
		public int Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}


	}

	public class Draw : Point
	{
		public Draw(int x, int y) : base (x, y)
		{
		}

		public static void Render(Point point, char symbol)
        {
			Console.SetCursorPosition(point.X, point.Y);
			Console.Write(symbol);
        }
	}

	public class Map : Point
    {
		private const char _symbol = '#';
		private List<Point> _walls = new List<Point>();

		public Map (int x, int y) : base(x, y)
		{
			DrawHorisontalWall(x, 0);
			DrawHorisontalWall(x, y);
			DrawVerticalWall(0, y);
			DrawVerticalWall(x, y);
		}

		public void DrawHorisontalWall(int x, int y)
        {
			for (int i = 0; i <= x; i++)
            {
				Point partWall = new Point(i, y);
				Draw.Render(partWall, _symbol);
				_walls.Add(partWall);
            }
        }

		public void DrawVerticalWall(int x, int y)
		{
			for (int i = 1; i <= y; i++)
			{
				Point partWall = new Point(x, i);
				Draw.Render(partWall, _symbol);
				_walls.Add(partWall);
			}
		}

		public bool IsHit(Point headSnake)
        {
			foreach (var w in _walls)
            {
				if (headSnake == w) return true;
            }

			return false;
        }
	}

	public class Food : Point
    {
		private const char _symbol = '@';
		private Random _random = new Random();
		private Point _food;
		

		public Food (int x , int y) : base (x, y)
        {
			_food = new Point(x, y);
			FoodRender();
        } 

        public void FoodRender()
        {
			_food = new Point(_random.Next(2, _food.X - 2), _random.Next(2, _food.Y - 2));

			if (IsFoodOnSnake(Snake._snake) == false)
            {
				Draw.Render(_food, _symbol);
			}
			
        }

		private bool IsFoodOnSnake(List<Point> snake)
        {
			foreach (var s in snake)
            {
				if (_food == s)
				{
					return true;
				}
			}

			return false;
        }

		public bool IsEating(Point snake)
        {
			if (snake == _food)
            {
				return true;
            }

			return false;
        }
		
    }

	public enum Direction
	{ 
		Left,
		Right,
		Up,
		Down
	}


	public class Snake : Point
	{
		public static List<Point> _snake = new List<Point>();
		private	const char _symbol = 'o';
		private const int _step = 1;
		private bool _rotate = true;
		private Direction _direction;
		private Point _head;
		private Point _tail;
		

		public Snake(int x, int y, int length) : base(x, y)
		{
			_direction = Direction.Right;

			for (int i = x - length; i < x; i++)
			{ 
				Point part = new Point(i, y);
				Draw.Render(part, _symbol);
				_snake.Add(part);
			}
		}

		public Point GetHead() => _snake.Last();

		public void Move()
        {
			_head = MovingPoint();
			_snake.Add(_head);
			_tail = _snake.First();
			_snake.Remove(_tail);
			_tail = null;

			Draw.Render(_head, _symbol);
        }

		public Point MovingPoint()
        {
			Point s = GetHead();

			switch (_direction)
			{
				case Direction.Right:
						s.X += _step;
					break;
				case Direction.Left:
						s.X -= _step;
					break;
				case Direction.Up:
						s.Y -= _step;
					break;
				case Direction.Down:
						s.Y += _step;
					break;
			}

			return s;
        }

		public bool IsEating(Point food)
        {
			_head = MovingPoint();

			if (_head == food)
            {
				IncreaseBody();
				return true;
			}
			return false;
        }

		public void IncreaseBody()
        {
			_snake.Add(_head);
			Draw.Render(_head, _symbol);
		}

		public void Turning(ConsoleKey key)
        {
			if (_rotate)
            {
				switch (_direction)
                {
					case Direction.Left:
					case Direction.Right:
						if (key == ConsoleKey.W)
                        {
							_direction = Direction.Up;
                        }
						else if (key == ConsoleKey.S)
                        {
							_direction = Direction.Down;
                        }
						break;
					case Direction.Up:
					case Direction.Down:
						if (key == ConsoleKey.D)
						{
							_direction = Direction.Right;
						}
						else if (key == ConsoleKey.A)
						{
							_direction = Direction.Left;
						}
						break;
				}
            }

			_rotate = false;
        }

		public bool IsHit(Point head)
        {
			for (int i = _snake.Count - 2; i > 0; i--)
            {
				if (_snake[i] == head)
                {
					return true;
                }
            }

			return false;
        }

		public bool IsWin()
		{
			if (_snake.Count - 1 == 79 * 25)
			{
				return true;
			}

			return false;
		}
	}
}
