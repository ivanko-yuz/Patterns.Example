using System;

namespace Patterns.Example.FactoryMethod
{
    /// <summary>
    /// Фабричний Метод вирішує, яку реалізацію інстанціювати. Вирішують або нащадки Фабричного Методу, або він сам, приймаючи якийсь параметр.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            const ClotheProviders provider = ClotheProviders.Trousers;
            var clothes = ClothProviderFactory.GetClothesPrinter(provider);

            clothes.PrintClothes();

            clothes = ClothProviderFactory.GetClothesPrinter(ClotheProviders.Shirt);
            clothes.PrintClothes();


            Console.ReadKey();

        }
    }
}
