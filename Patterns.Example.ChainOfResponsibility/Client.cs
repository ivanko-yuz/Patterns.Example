using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Example.ChainOfResponsibility
{
    public class Client
    {
        public static void Do(BaseHandler handler)
        {

            Console.WriteLine("Sending bool item");
            handler.Handle(true);

            Console.WriteLine("----------------");

            Console.WriteLine("Sending int item");
            handler.Handle(1);

            Console.WriteLine("----------------");

            Console.WriteLine("Sending string item");
            handler.Handle("string");

            Console.WriteLine("----------------");
            
            Console.WriteLine("Sending char item");
            handler.Handle('a');

            Console.WriteLine("----------------");
        }
    }
}
