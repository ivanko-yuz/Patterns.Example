
using System;
using Patterns.Example.AbstractFabric.Models;


namespace Patterns.Example.AbstractFabric.Factories
{
    public class WoodenToysFactory : IToyFactory
    {
        public Bear GetBear()
        {
            return new WoodenBear("Wooden Bear");
        }

        public Cat GetCat()
        {
            throw new NotImplementedException();
        }
    }
}
