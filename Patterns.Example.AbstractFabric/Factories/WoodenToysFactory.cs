
using System;
using Patterns.Example.AbstractFabric.Models;


namespace Patterns.Example.AbstractFabric.Factories
{
    public class WoodenToysFactory : IToyFactory
    {
        public override Bear GetBear()
        {
            return new WoodenBear("Wooden Bear");
        }

        public override Cat GetCat()
        {
            throw new NotImplementedException();
        }
    }
}
