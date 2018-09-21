using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Example.Decorator
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Some component implementation");
        }
    }
}
