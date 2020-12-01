using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    //Создаём интерфейс для наблюдателя
    public interface IObserver
    {
        //Создаём метод для приема уведомления о изменении какого-либо свойства в наследниках ISubject 
        void Update(ISubject subject);
    }
}
