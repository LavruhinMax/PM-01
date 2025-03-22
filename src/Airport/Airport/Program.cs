using Airport.Model;
using Airport.ViewModel;

namespace Airport
{
    class Program
    {
        public static void Main(string[] args)
        {
            FlightControl flightControl = new FlightControl();

            int length;
            Console.WriteLine("--------------------------");
            while (true)
            {
                Console.Write("Введите размер массива: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out length) && length > 0)
                    break;
                else
                    Console.WriteLine("Длина массива может быть только целым неотрицательным значением!");
            }

            for (int i = 0; i < length; i++)
            {
                flightControl.Flights.Add(insertData(i));
            }
            flightControl.Sort();
            flightControl.SaveToFile();

            Console.WriteLine("Данные сохранены в текстовый файл в директории Data");
            Console.ReadKey();
        }

        public static Flight insertData(int num)
        {
            Flight fl;
            int hour, min;
            string dep, arr;

            // Получаем данные от пользователя
            Console.WriteLine();
            Console.WriteLine("---- Рейс №" + (num + 1) + " ----");
            Console.Write("Аэропорт отправления: ");
            dep = Console.ReadLine();
            Console.Write("Аэропорт прибытия: ");
            arr = Console.ReadLine();
            while (true)
            {
                Console.Write("Час отправления (0-23): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out hour))
                {
                    if (hour >= 0 && hour <= 23)
                        break;
                    else
                        Console.WriteLine("Час может быть только в диапазоне от 0 до 23 включительно!");
                }
                else
                    Console.WriteLine("Время может быть только целым неотрицательным значением!");
            }
            while (true)
            {
                Console.Write("Минута отправления (0-59): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out min))
                {
                    if (min >= 0 && min <= 59)
                        break;
                    else
                        Console.WriteLine("Минута может быть только в диапазоне от 0 до 59 включительно!");
                }
                else
                    Console.WriteLine("Время может быть только целым неотрицательным значением!");
            }
            // Создаем экземпляр класса и добавляем его в коллекцию flightControl.Flights
            fl = new Flight()
            {
                DepartureAirport = dep,
                ArrivalAirport = arr,
                Hour = hour,
                Minute = min
            };
            return fl;
        }
    }
}
