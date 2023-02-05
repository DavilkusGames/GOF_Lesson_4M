using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lesson_4M_Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WheatherData wheatherData = new WheatherData();
            CurrentConditionsDisplay display1 = new CurrentConditionsDisplay(wheatherData);

            wheatherData.TestMethod(10, 20, 30);

            Console.ReadLine();
        }
    }
}
