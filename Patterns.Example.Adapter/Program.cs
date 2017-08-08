using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Example.Adapter.Models;

namespace Patterns.Example.Adapter
{
    /// <summary>
    /// Адаптер надає можливість користуватися об’єктом, який не є прийнятним у нашій системі і який не можна змінити. 
    /// Ми адаптуємо його функціональність через інший, відомий нашій системі, інтерфейс
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var newElectricitySystem = new NewElectricitySystem();
            ElectricityConsumer.ChargeNoteBook(newElectricitySystem);

            var oldElectricitySystem = new OldElectricitySystem();
            ElectricityConsumer.ChargeNoteBook(new Adapter(oldElectricitySystem));

            Console.ReadKey();
        }
    }
}
