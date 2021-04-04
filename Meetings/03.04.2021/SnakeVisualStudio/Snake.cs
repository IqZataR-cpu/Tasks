using System;

namespace Snake
{
    public class Snake
    {
        private readonly char _snakeSymbol;
        
        enum Direction 
        {
            Left,
            Right,
            Up,
            Down
        }
        
        public Snake(char symbol)
        {
            _snakeSymbol = symbol;
        }
        
        public void Rotation(ConsoleKey consoleKey)
        {
            throw new NotImplementedException();
        }

        public Point GetHead()
        {
            throw new NotImplementedException();
        }

        public bool IsHitYourSelf(Point yourSelf)
        {
            throw new NotImplementedException();
        }

        public bool Eat(Point foodFactoryFood)
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}