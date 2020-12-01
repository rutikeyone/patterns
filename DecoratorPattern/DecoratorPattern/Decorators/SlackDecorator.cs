using System;
using DecoratorPattern.Components;

namespace DecoratorPattern
{
    /*Конкретный декоратор(обертка), наследуется от абстрактного декоратора
      Он вызывает класс в обертке через base.Notify и изменяет его работу каким-то образом
     */
    public class SlackDecorator : Decorator
    {
        public SlackDecorator(Notifier notify) : base(notify){}

        //Вызывает родительскую реализацию, это упрощает использование декораторов
        public override string Notify(string message)
        {
            return $"Slack оповещение + {base.Notify(message)}";
        }
    }
}
