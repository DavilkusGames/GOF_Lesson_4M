using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF_Lesson_4M_Observer
{
    // Наблюдатель за субъектом
    public interface IObserver
    {
        // Метод вызывается при изменении данных в субъекте
        void Update(float temp, float humidity, float pressure);
    }
}
