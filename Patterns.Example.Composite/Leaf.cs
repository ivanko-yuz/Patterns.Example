using System;

namespace Patterns.Example.Composite
{
    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            Console.WriteLine("Can't add element to leaf ");
        }

        public override void Remove(Component c)
        {
            Console.WriteLine("Can't remove element from leaf ");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
