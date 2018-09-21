
using System;
using Patterns.Example.Builder.Builders;

namespace Patterns.Example.Builder
{
    /// <summary>
    /// Будівельник вимальовує стандартний процес створення складного обєкта відділяючи логіку будування від його представлення
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var firstBuilder = new MargaritaPizzaBuilder();
            var secondBuilder = new CustomPizzaBuilder();

            var shop = new Shop();

            shop.SetPizzaBuilder(firstBuilder);
            shop.ConstructNewPizza();

            var pizza1 = shop.Construct();

            shop.SetPizzaBuilder(secondBuilder);
            shop.ConstructNewPizza();

            var pizza2 = shop.Construct();


            Console.WriteLine(pizza1.ToString());
            Console.WriteLine(pizza2.ToString());

            Console.ReadKey();
        }
    }
}
