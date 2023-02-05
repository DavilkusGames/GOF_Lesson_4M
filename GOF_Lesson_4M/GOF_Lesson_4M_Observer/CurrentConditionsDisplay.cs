using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lesson_4M_Observer
{
    internal class CurrentConditionsDisplay : IObserver, IDisplay
    {
        // субъект, на который подписываемся
        private ISubject weatherData;

        // for display
        float temp;
        float pressure; 

        public CurrentConditionsDisplay(WheatherData wheatherData)
        {
            this.weatherData = weatherData;
        }

        public void Display()
        {
            Console.Write($"Temp: {temp}, Pressure: {pressure}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.pressure = pressure;

            Display();
        }
    }
}
