using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Interfaces
{
    //Необходимо создать интерфейсы для издателя(ISubject)
    public interface ISubject
    {
        //Так же необходимо создать методы для подписки
        void Attach(IObserver observer);
        //Отписки
        void Detach(IObserver observer);
        //Уведомления
        void Notify();
    }
}
