using System;

namespace Patterns.Example.ChainOfResponsibility
{
    public class SecondHandler : BaseHandler
    {

        public override void Handle(object item)
        {
            if(item is char)
            {
                Console.WriteLine($"Second handler handled the item :{item} typeof: {item.GetType()}");
            }
            else
            {
                base.Handle(item);
            }
        }
    }
}
