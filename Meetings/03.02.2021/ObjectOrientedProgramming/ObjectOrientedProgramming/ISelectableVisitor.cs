using System;

namespace ObjectOrientedProgramming
{
    public interface ISelectableVisitor
    {
        public void Visit(Selectable unit);
        public void Visit(Unit unit);
        public void Visit(Squad squad);
    }
 
    public class Print : ISelectableVisitor
    {
        // Тут реализация логики визитера
        public void Visit(Selectable unit)
        {
            Console.WriteLine("Посетили сущность");
        }

        public void Visit(Unit unit)
        {
            Console.WriteLine("Мы посетили юнита");
        }

        // Тут реализация логики визитера
        public void Visit(Squad squad)
        {
            foreach (var entity in squad.Entities)
            {
                entity.Accept(this);
            }
        }
    }
}