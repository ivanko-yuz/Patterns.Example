using System;

namespace Patterns.Example.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent concreteComponent = new ConcreteComponent();

            Decorator decoratedComponentA = new ConcreteDecoratedComponentA();
            Decorator decoratedComponentB = new ConcreteDecoratedComponentB();

            decoratedComponentA.SetComponent(concreteComponent);


            decoratedComponentB.SetComponent(decoratedComponentA);

            concreteComponent.Operation();

            Console.WriteLine("-------------------------");

            decoratedComponentA.Operation();

            Console.WriteLine("-------------------------");

            decoratedComponentB.Operation();

            Console.ReadKey();

        }
    }
}
