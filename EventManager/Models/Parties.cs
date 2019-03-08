using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class Parties
    {
        public Parties() { }
        public string name { get; set; }
        public string university { get; set; }
        public string course { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        //public Date date;
    }

    public partial class Date
    {
        public Date(int _day, int _time)
        {
            Day = _day;
            Time = _time;
        }
        public int Day { get; set; }
        public int Time { get; set; }
        public DateTime ToDateTime()
        {
            return DateTime.ParseExact($"{Day} {Time}", "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        }
    }

}

