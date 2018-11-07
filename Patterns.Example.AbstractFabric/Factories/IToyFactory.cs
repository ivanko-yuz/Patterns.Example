
using Patterns.Example.AbstractFabric.Models;

namespace Patterns.Example.AbstractFabric
{
    public abstract class IToyFactory
    {
        public abstract Bear GetBear();
        public abstract Cat GetCat();
    }
}
