
using Patterns.Example.AbstractFabric.Models;

namespace Patterns.Example.AbstractFabric
{
    public interface IToyFactory
    {
        Bear GetBear();
        Cat GetCat();
    }
}
