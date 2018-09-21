using Patterns.Example.AbstractFabric.Models;

namespace Patterns.Example.AbstractFabric.Factories
{
    public class TeddyToyFactory: IToyFactory 
    {
        public override Bear GetBear()
        {
            return new TeddyBear("Teddy Bear");
        }

        public override Cat GetCat()
        {
            return new TeddyCat("Teddy Cat");
        }
    }
}
