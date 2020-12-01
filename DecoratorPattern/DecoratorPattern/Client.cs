using System;
using DecoratorPattern.Components;

namespace DecoratorPattern
{
    //Класс имитирующий бизнес логику
    public class Client
    {
        //Метод, имитирующий бизнес логику
        public string Notify(Notifier notifier, string message)
        {
            return notifier.Notify(message);
        }
    }
}
