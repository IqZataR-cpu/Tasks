using System;

namespace Decorator
{
    public class Select : Widget
    {
        public override void Draw()
        {
            Console.WriteLine("Селект нарисован");
        }
    }
}