using System;
using System.Collections.Generic;

namespace Patterns.Example.Bridge
{
    class CustomersData2 : DataObject

    {
        private List<string> _customers = new List<string>();
        private int _current = 0;

        public CustomersData2()
        {
            // Loaded from a database 
            _customers.Add("Jim2 Jones2");
            _customers.Add("Samual2 Jackson2");
            _customers.Add("Allen2 Good2");
        }

        public override void NextRecord()
        {
            if (_current <= _customers.Count - 1)
            {
                _current++;
            }
        }

        public override void PriorRecord()
        {
            if (_current > 0)
            {
                _current--;
            }
        }

        public override void AddRecord(string customer)
        {
            _customers.Add(customer);
        }

        public override void DeleteRecord(string customer)
        {
            _customers.Remove(customer);
        }

        public override void ShowRecord()
        {
            Console.WriteLine(_customers[_current]);
        }

        public override void ShowAllRecords()
        {
            foreach (string customer in _customers)
            {
                Console.WriteLine("-" + customer);
            }
        }
    }
}
