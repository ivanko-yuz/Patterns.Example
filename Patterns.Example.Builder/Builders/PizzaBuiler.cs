using Patterns.Example.Builder.Model;

namespace Patterns.Example.Builder.Builders
{
    public abstract class PizzaBuiler
    {
        protected Pizza Pizza { get; private set; }

        protected PizzaBuiler()
        {
            Pizza = new Pizza();
        }

        //public void CreateNewPizza()
        //{
        //    Pizza = new Pizza();
        //}

        public Pizza GetMyPizza()
        {
            return Pizza;
        }

        public abstract void SetPrice();
        public abstract void SetSize();
        public abstract void SetLindOfCheese();
    }
}
