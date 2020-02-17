using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Food_Log
{
    public class Event
    {
        public static Event[] EventList = { };
        public string Description { get; set; }
        public string State { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public Event(string description, string state, string date, string time)
        {
            Description = description;
            State = state;
            Date = date;
            Time = time;
        }
    }
}