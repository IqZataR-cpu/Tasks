using System.Collections.Generic;

namespace Snake
{
    public class Walls
    {
        private readonly char _wallSymbol;
        private List<Point> _wall = new List<Point>();

        public Walls(int x, int y, char symbol)
        {
            this._wallSymbol = symbol;
            DrawHorizontal(x, 0);
            DrawHorizontal(x, y);
            DrawVertical(0, y);
            DrawVertical(x, y);
        }

        private void DrawHorizontal(int x, int y)
        {
            for (var i = 0; i < x; i++)
            {
                Point point = (i, y, _wallSymbol);
                point.Draw();
                _wall.Add(point);
            }
        }
        
        private void DrawVertical(int x, int y) 
        {
            for (var i = 0; i < y; i++)
            {
                Point point = (x, i, _wallSymbol);
                point.Draw();
                _wall.Add(point);
            }
        }

        public bool IsHitBySnake(Point snakeHead)
        {
            throw new System.NotImplementedException();
        }
    }
}