using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lesson_4M_Observer
{
    internal class AllConditionsDisplay : IObserver, IDisplay
    {
        // субъект, на который подписываемся
        private ISubject weatherData;

        // for display
        float temp;
        float humidity;
        float pressure;

        public AllConditionsDisplay(WheatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.Write($"Temp: {temp}, Humidity: {humidity}, Pressure: {pressure}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            Display();
        }
    }
}
