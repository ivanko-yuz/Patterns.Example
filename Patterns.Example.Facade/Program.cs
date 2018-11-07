using System;

namespace Patterns.Example.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facede = new Facade();

            facede.MethodA();

            Console.WriteLine("--------------");
            
            facede.MethodB();

            Console.WriteLine("--------------");

            facede.MethodC();

            Console.WriteLine("--------------");

            facede.MethodD();

            Console.ReadKey();
        }
    }
}
