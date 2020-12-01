using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.BaseClasses
{
    /*
    Создаём абстрактный класс который будет общим для всех классов, он нужен для того чтобы инициализировать
    IMediator и вызвать Notify то есть мы фактичестки делаем так IMediator Mediator = new ConcreteMediator(); 
    Mediator.Notify(this,сообщение); 
    */
    abstract class Aircraft
    {
        protected IMediator Mediator;

        public void SetMediator(IMediator mediator)
        {
            this.Mediator = mediator;
        }
    }
}
