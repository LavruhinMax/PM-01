using Airport.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.ViewModel
{
    public class FlightControl
    {
        public List<Flight> Flights = new List<Flight>();

        public void Sort() => Flights = Flights.OrderBy(flight => flight.Hour).ThenBy(flight => flight.Minute).ToList();

        public void SaveToFile()
        {

        }
    }
}
