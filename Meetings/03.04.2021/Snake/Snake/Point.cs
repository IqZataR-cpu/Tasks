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
            return new()
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
        
        public void Draw()
        {
            DrawPoint(Symbol);
        }
        
        public void Clear()
        {
            DrawPoint(' ');
        }
        private void DrawPoint(char symbol)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(symbol);
        }
    }
}