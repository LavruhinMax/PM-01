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
            // Получаем путь к директории
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            // Указываем путь к файлу
            string filePath = Path.Combine(baseDirectory, "..", "..", "..", "Data", "FlightsList.txt");
            filePath = Path.GetFullPath(filePath);

            // Используем StreamWriter для записи в txt
            using (StreamWriter sw = new(filePath))
            {
                foreach (var flight in Flights)
                {
                    sw.WriteLine($"{flight.DepartureAirport} -> ({flight.ArrivalAirport}) {flight.Hour}:{flight.Minute}");
                }
            }
        }
    }
}
