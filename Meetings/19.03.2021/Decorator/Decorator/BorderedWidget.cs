using System;

namespace Decorator
{
    public class BorderedWidget : WidgetDecorator
    {
        private int _borderSize;
        
        public BorderedWidget(Widget widget, int borderSize) : base(widget)
        {
            _borderSize = borderSize;
        }

        public override void Draw()
        {
            base.Draw();
            DrawBorder();
        }

        private void DrawBorder()
        {
            Console.WriteLine($"Граница с размером {_borderSize} нарисована");
        }
    }
}