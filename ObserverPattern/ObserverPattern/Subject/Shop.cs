using System;
using System.Collections.Generic;
using ObserverPattern.Interfaces;


namespace ObserverPattern.Subject
{
    //Создаём класс издателя
    public class Shop : ISubject
    {
        //Важное поле при изменении которого необходимо уведомить подписчиков
        public bool IsHaveBreak = false;

        //Cоздаём список подписчиков
        private List<IObserver> Observers = new List<IObserver>();

        //Реализуем класс ISubject
        public void Attach(IObserver observer)
        {
            //Добавляем подписчика
            Observers.Add(observer);
        }

        //Реализуем класс ISubject
        public void Detach(IObserver observer)
        {
            //Удаляем подписчика
            Observers.Remove(observer);
        }

        //Реализуем класс ISubject
        public void Notify()
        { 
            //Уведомляем подписчиков
           foreach(var observer in Observers)
           {
                observer.Update(this);
           }
        }

        //Выполняем какую-нибудь работу, в данном примере это завоз хлеба и уведомляем об этом подписчиков 
        public void GetBread()
        {
            this.IsHaveBreak = true;
            //Вот тут
            this.Notify();
        }
    }
}
