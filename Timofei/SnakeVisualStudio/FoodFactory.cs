using System;

namespace Snake
{
    class FoodFactory
    {
        private readonly int _xBorder;
        private readonly int _yBorder;
        private readonly char _symbol;
        
        private readonly Random _random = new Random();
        
        public Point Food { get; private set; }

        public FoodFactory(int xBorder, int yBorder, char symbol)
        {
            this._xBorder = xBorder;
            this._yBorder = yBorder;
            this._symbol = symbol;
        }

        public void CreateFood()
        {
            Food = (
                _random.Next(2, _xBorder - 2),
                _random.Next(2, _yBorder - 2),
                _symbol
            );
            
            Console.ForegroundColor = ConsoleColor.Red;
            Food.Draw();
            Console.ResetColor();
        }
    }
}