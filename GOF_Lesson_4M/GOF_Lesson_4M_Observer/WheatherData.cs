using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lesson_4M_Observer
{
    public class WheatherData : ISubject
    {
        private List<IObserver> observers;

        private float temp;
        private float humidity;
        private float pressure;

        public WheatherData()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temp, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void TestMethod(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;

            MeasurementsChanged();
        }
    }
}
