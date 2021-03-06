﻿namespace Decorator
{
    // Описание:
    // У нас есть некие виджеты для графического представления объектов.
    // Они все имеют метод отрисовки, у каждого свой,
    // в данном случае метод имеет "затычную реализацию",
    // то есть сделан, чисто для примера
    // 
    // Задание:
    // Заказчик захотел иметь возможность добавить рамку(границу(border)) и тень(shadow) для наших виджетов.
    // Дополнить классы возможностью рисования тени и рамки,
    // функциями "затычками", которые вызывались бы во время рисования виджетов
    // для придания им дополнительных визуальных эффектов. 
    // В нашем случае достаточно вывода в консоль сообщения.
    // Создать несколько разные виджетов с различными комбинациями эффектов.
    // Пример:
    // Текстбокс с рамкой и тенью,
    // Селект с рамкой,
    // Текстбокс,
    // Селект с тенью.
    // 
    // ВАЖНО: Тень и рамка не должны отрисовываться всегда,
    // только если мы условно выбрали это в редакторе, то есть при определенном условии.
    // Предусмотреть возможность установления двойной рамки.(не обязательно, но желательно)
    class Program
    {
        static void Main(string[] args)
        {
            Widget textBox = new TextBox();
            WidgetFactory widgetFactory = new WidgetFactory();
            
            textBox = widgetFactory.AddBorder(textBox, 4);
            textBox = widgetFactory.AddBorder(textBox, 8);
            textBox = widgetFactory.AddBorder(textBox, 8);
            textBox.Draw();
        }
    }

    public class WidgetFactory
    {
        public Widget AddBorder(Widget widget, int borderSize)
        {
            return new BorderedWidget(widget, borderSize);
        }      
        
        public Widget AddShadow(Widget widget, int shadowSize)
        {
            return new ShadowWidget(widget, shadowSize);
        }
    }
}