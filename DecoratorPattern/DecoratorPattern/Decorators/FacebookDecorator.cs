using System;
using DecoratorPattern.Components;

namespace DecoratorPattern
{
    /*Конкретный декоратор(обертка), наследуется от абстрактного декоратора
      Он вызывает класс в обертке через base.Notify и изменяет его работу каким-то образом
     */
    public class FacebookDecorator : Decorator
    {
        public FacebookDecorator(Notifier notifier) : base(notifier){}

        //Вызывает родительскую реализацию, это упрощает использование декораторов
        public override string Notify(string message)
        {
            return  $"Facebook оповещение + {base.Notify(message)}";
        }
    }
}
