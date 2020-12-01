using System;
using DecoratorPattern.Components;

namespace DecoratorPattern
{
    /*Базовый класс декоратора, наследуется от кого же класса что и конкретные компоненты
      Этот класс определяет родительский класс для всех конкретных декораторов
      Использует ассоциацию и агрегацию
     */
    public abstract class Decorator : Notifier
    {
        protected Notifier Notifier; //Ассоциация
        public Decorator(Notifier notifier) //Агрегация
        {
            Notifier = notifier;
        }

        public void SetComponent(Notifier notifier)
        {
            Notifier = notifier;
        }

        //Делегирует работу конкретному декоратору
        public override string Notify(string message)
        {
            if (this.Notifier != null) //Проверка есть ли ссылка на объект
            {
                return this.Notifier.Notify(message);
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
