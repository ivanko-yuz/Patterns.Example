using System;

namespace Patterns.Example.ChainOfResponsibility
{
    public class FourthHandler : BaseHandler
    {

        public override void Handle(object item)
        {
            if(item is string)
            {
                Console.WriteLine($"Forth handler handled the item :{item} typeof: {item.GetType()}");
            }
            else
            {
                base.Handle(item);
            }
        }
    }
}
