
namespace Patterns.Example.Builder.Builders
{
    public class CustomPizzaBuilder : PizzaBuiler
    {
        //public CustomPizzaBuilder()
        //{
        //   // CreateNewPizza();
        //}

        public override void SetLindOfCheese()
        {
            base.Pizza.KindOfChese = "Just Cheese";
        }

        public override void SetSize()
        {
            base.Pizza.Size = 15;
        }

        public override void SetPrice()
        {
            base.Pizza.Price = 20;
        }
    }
}
