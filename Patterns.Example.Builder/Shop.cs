using Patterns.Example.Builder.Builders;
using Patterns.Example.Builder.Model;

namespace Patterns.Example.Builder
{
    public class Shop
    {
        private PizzaBuiler _pizzaBuiler;

        public void SetPizzaBuilder(PizzaBuiler builder)
        {
            _pizzaBuiler = builder;
        }

        public Pizza Construct()
        {
            return _pizzaBuiler.GetMyPizza();
        }

        public void ConstructNewPizza()
        {
            _pizzaBuiler.SetPrice();
            _pizzaBuiler.SetLindOfCheese();
            _pizzaBuiler.SetSize();
        }
    }
}
