namespace Decorator
{
    public class WidgetDecorator : Widget
    {
        private Widget _widget;

        public WidgetDecorator(Widget widget)
        {
            _widget = widget;
        }

        public override void Draw()
        {
            _widget.Draw();
        }
    }
}