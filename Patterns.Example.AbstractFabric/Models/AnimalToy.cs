
using System;

namespace Patterns.Example.AbstractFabric.Models
{
    public abstract class AnimalToy
    {
        public string Name { get; set; }
        protected AnimalToy(string name)
        {
            Name = name;
            Console.WriteLine($"{name}");
        }

    }
}
