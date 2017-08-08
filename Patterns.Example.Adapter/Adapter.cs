using Patterns.Example.Adapter.Models;

namespace Patterns.Example.Adapter
{
    public class Adapter : INewElectricitySystem
    {
        private readonly OldElectricitySystem _adaptee;

        public Adapter(OldElectricitySystem adaptee)
        {
            this._adaptee = adaptee;
        }

        public string MatchWideSocet()
        {
            return _adaptee.MatchThinSocket();
        }
    }
}
