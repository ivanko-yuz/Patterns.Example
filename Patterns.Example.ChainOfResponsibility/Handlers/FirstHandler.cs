using System;

namespace Patterns.Example.ChainOfResponsibility
{
    public class FirstHandler : BaseHandler
    {

        public override void Handle(object item)
        {
            if(item is int)
            {
                Console.WriteLine($"First handler handled the item :{item} typeof: {item.GetType()}");
            }
            else
            {
                base.Handle(item);
            }
        }
    }
}
