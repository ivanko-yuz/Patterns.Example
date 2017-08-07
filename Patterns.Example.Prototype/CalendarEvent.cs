using System;

namespace Patterns.Example.Prototype
{
    public class CalendarEvent : CalendarPrototype
    {
        public DateTime StartDateAndTime { get; set; }
        public string Priority { get; set; }
        public string[] Attendees { get; set; }
    }
}
