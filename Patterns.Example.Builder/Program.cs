
using System;
using Patterns.Example.Builder.Builders;

namespace Patterns.Example.Builder
{
    /// <summary>
    /// Будівельник вимальовує стандартний процес створення складного оюєкта відділяючи логіку будуваггя від його представлення
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var firstBuilder = new MargaritaPizzaBuilder();
            var secondBuilder = new CustomPizzaBuilder();

            var shop = new BuyPizza();

            shop.SetPizzaBuilder(firstBuilder);
            shop.ConstructNewPizza();

            var pizza1 = shop.GetPizza();

            shop.SetPizzaBuilder(secondBuilder);
            shop.ConstructNewPizza();

            var pizza2 = shop.GetPizza();


            Console.WriteLine(pizza1.ToString());
            Console.WriteLine(pizza2.ToString());

            Console.ReadKey();
        }
    }
}
