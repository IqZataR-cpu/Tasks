using System.Collections.Generic;

namespace ObjectOrientedProgramming
{
    public interface ISelectable
    {
        public void Accept(ISelectableVisitor visitor);
    }

    public abstract class Selectable : ISelectable
    {
        public virtual void Accept(ISelectableVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
    
    public class Unit : Selectable
    {
        public override void Accept(ISelectableVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class Squad : Selectable
    {
        private List<ISelectable> _entities = new List<ISelectable>();

        public List<ISelectable> Entities => _entities;

        public override void Accept(ISelectableVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Add(ISelectable entity)
        {
            _entities.Add(entity);
        }
    }
}