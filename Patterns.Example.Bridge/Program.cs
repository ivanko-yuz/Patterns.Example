using System;

namespace Patterns.Example.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create RefinedAbstraction

            Customers customers = new Customers("Chicago")
            {
                // Set ConcreteImplementor
                Data = new CustomersData()
            };


            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");


            customers.ShowAll();


            customers.Data = new CustomersData2();


            customers.Show();
            customers.Next();

            customers.ShowAll();


            // Wait for user

            Console.ReadKey();
        }
    }
}
