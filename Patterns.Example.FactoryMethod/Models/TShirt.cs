using System;

namespace Patterns.Example.FactoryMethod.Models
{
    public class Shirt : IClothes
    {
        public void PrintClothes()
        {
            Console.WriteLine("Shirt");
        }
    }
}
