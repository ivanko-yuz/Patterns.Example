using System;

namespace Patterns.Example.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstHandler = new FirstHandler();
            var secondHandler = new SecondHandler();
            var thirdHandler = new ThirdHandler();
            var fourthHandler = new FourthHandler();

            firstHandler.SetNext(secondHandler).SetNext(secondHandler).SetNext(thirdHandler).SetNext(fourthHandler);

            Client.Do(firstHandler);

            Console.ReadKey();

        }
    }
}
