using System;

namespace Patterns.Example.FactoryMethod.Models
{
    public class Trousers : IClothes 
    {
        public void PrintClothes()
        {
            Console.WriteLine("Trausers");
        }
    }
}
