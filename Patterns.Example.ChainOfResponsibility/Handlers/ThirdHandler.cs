using System;

namespace Patterns.Example.ChainOfResponsibility
{
    public class ThirdHandler : BaseHandler
    {

        public override void Handle(object item)
        {
            if (item is bool)
            {
                Console.WriteLine($"Third handler handled the item :{item} typeof: {item.GetType()}");
            }
            else
            {
                base.Handle(item);
            }
        }
    }
}
