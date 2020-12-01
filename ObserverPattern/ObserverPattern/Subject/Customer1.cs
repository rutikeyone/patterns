using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    //Создаем конкретного наблюдателя и реализуем IObserver
    public class Customer1 : IObserver
    { 
        //Есть ли у нас дома хлеб
        private bool IsNeedBread = true;
        public void Update(ISubject subject)
        {
            //Если хлеб привезли и у нас нет хлеба идем в магазин
            if ((subject as Shop).IsHaveBreak && IsNeedBread)
            {
                Console.WriteLine("Покупатель 1 идет в магазин за хлебом");
            }
            //Если хлеб привезли и у нас есть хлеб уведомляем об этом
            else if ((subject as Shop).IsHaveBreak && !IsNeedBread)
            {
                Console.WriteLine("В магазин привезли хлеб, но он есть у меня дома");
            }

        }
    }
}
