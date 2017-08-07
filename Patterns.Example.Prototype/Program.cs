using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Example.Prototype
{
    /// <summary>
    /// Прототип дозволяє нам створювати копії об’єктів, що уже визначені на стадії дизайну 
    /// (наприклад, список можливих типів зустрічей) або ж визначаються під час виконання програми 
    /// («п’ятнична вечірка»), таким чином, відпадає необхідність заповнювати всі елементи об’єкту від А до Я. 
    /// Уже створені або визначені екземпляри об’єкту називаються прототипічними екземплярами (prototypical instances).16 
    /// </summary>
    class Program
    { 
        static void Main(string[] args)
        {
            var beeParty = GetExistingEvent();

            var nextFridayParty = (CalendarEvent) beeParty.Clone();
            nextFridayParty.StartDateAndTime.AddDays(7);
        }


        public static CalendarEvent GetExistingEvent()
        {
            var beerParty = new CalendarEvent();
            var friends = new string[] {"Ivan", "Ihor"};


            beerParty.Attendees = friends;
            beerParty.StartDateAndTime = DateTime.UtcNow;

            beerParty.Priority = "high";

            return beerParty;
        }
    }
}
