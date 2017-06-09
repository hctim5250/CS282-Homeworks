using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStationLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            WeatherData data = new WeatherData();

            Console.WriteLine("請輸入溫度");
            double temperature = double.Parse(Console.ReadLine());
            data.Temperature = temperature;
            Console.WriteLine("您輸入的是{0}，結果是{1}", temperature, data.Temperature);

            Console.WriteLine("請輸入濕度");
            double humidity = double.Parse(Console.ReadLine());
            data.Humidity = humidity;
            Console.WriteLine("您輸入的是{0}，結果是{1}", humidity, data.Humidity);

            Console.WriteLine("請輸入壓力");
            double pressure = double.Parse(Console.ReadLine());
            data.Pressure = pressure;
            Console.WriteLine("您輸入的是{0}，結果是{1}", pressure, data.Pressure);
        }
    }
}