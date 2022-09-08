using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WeatherData
    {

        private string? _Scale;
        public string? Scale
        {
            get { return _Scale; }
            set
            {
                if (value == "C")
                {
                    _Scale = "C";
                }
                else if (value == "F")
                {
                    _Scale = "F";
                }
                else
                {
                    Console.WriteLine("Please use C for celsius or F for farenheit");
                }
            }
        }

        private double _Temperature;

        public double Temperature
        {
            get { return _Temperature; }
            set
            {
                if (_Scale == "C" && value < 60 && value > -60)
                {
                    _Temperature = value;
                }
                else if (_Scale == "F" && value < 140 && value > -76)
                {
                    _Temperature = value;
                }
                else
                {
                    Console.WriteLine("Temperature value seems unrealistic. A reading mistake must have been made.");
                }
            }
        }

        private int _Humidity;

        public int Humidity
        {
            get { return _Humidity; }
            set
            {
                if (value < 100 && value > 0)
                {
                    _Humidity = value;
                }
                else
                {
                    Console.WriteLine("Humidity value seems unrealistic. A reading mistake must have been made.");
                }
            }
        }

       

        public static void Convert(WeatherData weatherData)
        {
            Console.WriteLine(weatherData.Temperature + "°" + weatherData.Scale);
            if (weatherData.Scale == "C")
            {    
                double newTemperature = weatherData.Temperature * 9 / 5 + 32;
                weatherData.Scale = "F";
                Console.WriteLine(newTemperature + "°" + weatherData.Scale);
                weatherData._Temperature = newTemperature;
            } else if (weatherData.Scale == "F")
            {
                double newTemperature = (weatherData.Temperature - 32) * 5 / 9;
                weatherData.Scale = "C";
                Console.WriteLine(newTemperature + "°" + weatherData.Scale);
                weatherData._Temperature = newTemperature;
            }
        }

    }
}
