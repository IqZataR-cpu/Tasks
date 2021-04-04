using System;

namespace Snake
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        private char Symbol { get; set; }

        // Перезапись операторов,
        // первый - создание Point с использованием кортежа, только в .NetFramework4.7+
        // второй - перезапись оператора проверки "==", чтобы было легче сравнивать точки между собой.
        // третий - перезапись оператора проверки "!=", чтобы было легче сравнивать точки между собой.
        public static implicit operator Point((int, int, char) value)
        {
            return new Point
            {
                X = value.Item1,
                Y = value.Item2,
                Symbol = value.Item3
            };
        } 
        
        public static bool operator ==(Point a, Point b)
        {
            return a.X == b.X 
                   && a.Y == b.Y;
        }
        
        // Сокращенный вариант записи, некоторые это называют "синтаксический сахар"
        public static bool operator != (Point a, Point b) => 
            a.X != b.X || a.Y != b.Y;
        
        public void Draw(int color)
        {
            DrawPoint(Symbol, color);
        }
        
        public void Clear(int color)
        {
            DrawPoint(' ', color);
        }
        
        private void DrawPoint(char symbol, int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }

            Console.SetCursorPosition(X, Y);
            Console.Write(symbol);
        }
    }
}