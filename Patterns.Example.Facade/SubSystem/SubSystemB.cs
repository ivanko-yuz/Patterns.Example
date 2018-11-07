using System;

namespace Patterns.Example.Facade
{
    public class SubSystemB
    {
        public void MethodA()
        {
            Console.WriteLine("Doing method A in system B");
        }
        public void MethodB()
        {
            Console.WriteLine("Doing method B in system B");
        }
    }
}
