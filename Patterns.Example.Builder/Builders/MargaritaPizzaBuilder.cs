
namespace Patterns.Example.Builder.Builders
{
    public class MargaritaPizzaBuilder : PizzaBuiler
    {
        //public MargaritaPizzaBuilder()
        //{
        //    CreateNewPizza();
        //}

        public override void SetPrice()
        {
            base.Pizza.Price = 10;
        }

        public override void SetSize()
        {
            base.Pizza.Size = 5;
        }

        public override void SetLindOfCheese()
        {
            base.Pizza.KindOfChese = "The MOzarella";
        }
    }
}
