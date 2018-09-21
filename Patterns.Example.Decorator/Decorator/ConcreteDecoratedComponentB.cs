using System;

namespace Patterns.Example.Decorator
{
    public class ConcreteDecoratedComponentB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehaivior();
            Console.WriteLine("ConcreteDecoratedComponentB.Operation");
        }

        private void AddedBehaivior()
        {
            Console.WriteLine("Some other behaivior");
        }
    }
}
