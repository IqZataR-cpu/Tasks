using System;

namespace Decorator
{
    public class ShadowWidget : WidgetDecorator
    {
        private int _shadowSize;

        public ShadowWidget(Widget widget, int shadowSize) : base(widget)
        {
            _shadowSize = shadowSize;
        }

        public override void Draw()
        {
            base.Draw();
            DrawShadow();
        }

        private void DrawShadow()
        {
            Console.WriteLine($"Тень с размером {_shadowSize} нарисована");
        }
    }
}