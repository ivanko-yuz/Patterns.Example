using Patterns.Example.AbstractFabric.Models;

namespace Patterns.Example.AbstractFabric.Factories
{
    public class TeddyToyFactory: IToyFactory 
    {
        public Bear GetBear()
        {
            return new TeddyBear("Teddy Bear");
        }

        public Cat GetCat()
        {
            return new TeddyCat("Teddy Cat");
        }
    }
}
