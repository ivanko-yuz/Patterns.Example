using System;

namespace Patterns.Example.Proxy
{
    public class Proxy : Abstraction
    {
        private Abstraction realService;

        //TODO : ask how we use this!?
        public bool CheckAccess()
        {
            Console.WriteLine("Checking Access");
            return true;
        }

        //Here it looks like DECORATOR
        public override void Opretation()
        {
            if (CheckAccess())
            {
                if (realService != null)
                    realService = new Implementation();

                realService.Opretation();
            }
        }
    }
}
