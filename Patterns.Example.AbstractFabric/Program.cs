
using System;
using Patterns.Example.AbstractFabric.Factories;
using Patterns.Example.AbstractFabric.Models;

namespace Patterns.Example.AbstractFabric
{
    /// <summary>
    ///   Абстрактна фабрика надає простий інтерфейс для створення обєктів які належать до того чи іншого сімейства
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IToyFactory toyFactory = new TeddyToyFactory();
            var beartoy = toyFactory.GetBear();

            var catToy = toyFactory.GetCat();
            toyFactory = new WoodenToysFactory();
            var secondToy = toyFactory.GetBear();

            Console.WriteLine($"I have got {beartoy.Name} and {catToy.Name} and {secondToy.Name} ");

            Console.ReadKey();
        }
    }
}
