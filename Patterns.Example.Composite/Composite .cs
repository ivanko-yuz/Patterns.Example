using System;
using System.Collections.Generic;

namespace Patterns.Example.Composite
{
    public class Composite : Component
    {
        public List<Component> children = new List<Component>();

        public Composite(string name) 
            : base(name)
        {
        }

        public override void Add(Component component)
        {
            this.children.Add(component);
        }

        public override void Remove(Component component)
        {
            this.children.Remove(component);
        }

        public override void Display(int depth)
        {
            foreach (var component in children)
            {
                component.Display(depth + 2);
            }
        }

    }
}
