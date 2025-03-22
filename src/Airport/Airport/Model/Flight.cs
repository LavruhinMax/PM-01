using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Model
{
    public class Flight
    {
        public string DepartureAirport { get; set; } // Аэропорт отправления
        public string ArrivalAirport { get; set; } // Аэропорт прибытия
        public int Hour { get; set; } // Час отправления
        public int Minute { get; set; } // Минута отправления
    }
}
