using System;

namespace Decorator
{
    public class TextBox : Widget
    {
        public override void Draw()
        {
            Console.WriteLine("Текст бокс нарисован");
        }
    }
}