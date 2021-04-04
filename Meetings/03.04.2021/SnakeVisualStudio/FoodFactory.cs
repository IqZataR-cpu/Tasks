using System;

namespace Snake
{
    class FoodFactory
    {
        private readonly int _xBorder;
        private readonly int _yBorder;
        private readonly char _symbol;
        private int _color;

        private readonly Random _random = new Random();
        
        public Point Food { get; private set; }

        public FoodFactory(int xBorder, int yBorder, char symbol, int color)
        {
            _xBorder = xBorder;
            _yBorder = yBorder;
            _symbol = symbol;
            _color = color;
        }

        public void CreateFood()
        {
            do
            {
                Food = (
               _random.Next(2, _xBorder - 2),
               _random.Next(2, _yBorder - 2),
               _symbol
               );
            }
            while (Snake.isFoodOnSnake(Food));

            Food.Draw(_color);
        }
    }
}