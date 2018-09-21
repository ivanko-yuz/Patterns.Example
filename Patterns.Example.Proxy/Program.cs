using System;

namespace Patterns.Example.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction service = new Implementation();

            service.Opretation();

            service = new Proxy();

            service.Opretation();
        }
    }
}
