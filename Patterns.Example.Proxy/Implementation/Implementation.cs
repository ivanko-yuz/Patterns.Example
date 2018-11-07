using System;

namespace Patterns.Example.Proxy
{
    public class Implementation : Abstraction
    {
        public override void Opretation()
        {
            Console.WriteLine("Do something");
        }
    }
}
