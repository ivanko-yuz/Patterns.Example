using System;

namespace Patterns.Example.Decorator
{
    public class ConcreteDecoratedComponentA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratedComponentA.Operation");
        }
    }
}
