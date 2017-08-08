
namespace Patterns.Example.Adapter.Models
{
    public class NewElectricitySystem : INewElectricitySystem
    {
        public string MatchWideSocet()
        {
            return "220V";
        }
    }
}
