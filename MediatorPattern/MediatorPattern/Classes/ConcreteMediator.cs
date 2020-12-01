using MediatorPattern.BaseClasses;
using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Classes
{
    //Создаём класс ConcreteMediator и реализуем Notify
    class ConcreteMediator : IMediator
    {
        AirFighter F16;
        Bomber B52;
        HeliCopter AH64;


        /*
         В этом же классе в конструкторе инициализируем объекты которые как-то будут реагировать
         и инициализируем IMediator Mediator = new ConcereMediator(); чтобы не получить исключение
         */
        public ConcreteMediator(AirFighter airFighter, HeliCopter heliCopter, Bomber bomber)
        {
            F16 = airFighter;
            this.F16.SetMediator(this);
            AH64 = heliCopter;
            this.AH64.SetMediator(this);
            B52 = bomber;
            this.B52.SetMediator(this);
        }

        //В Notify реализуем конкретную логику реагирования классов в зависимости от получаемых значений
        public void Notify(Aircraft aircraft, string message)
        {
            if(aircraft is HeliCopter)
            {
                HeliCopter heliCopter = aircraft as HeliCopter;
                if(message.Equals("Взлетает", StringComparison.OrdinalIgnoreCase))
                {
                    F16.GetMessage($"{typeof(HeliCopter).Name} {message},F16 отмените посадку\n");
                    B52.GetMessage($"{typeof(HeliCopter).Name} {message},B52 отмените посадку\n");
                } 
            }


            if (aircraft is AirFighter)
            {
                AirFighter airFighter = aircraft as AirFighter;
                if (message.Equals("Взлетает", StringComparison.OrdinalIgnoreCase))
                {
                    AH64.GetMessage($"{typeof(AirFighter).Name} {message},AH64 отмените посадку\n");
                    B52.GetMessage($"{typeof(AirFighter).Name} {message},B52 отмените посадку\n");
                }
            }

            if (aircraft is Bomber)
            {
                Bomber bomber = new Bomber();
                if (message.Equals("Взлетает", StringComparison.OrdinalIgnoreCase))
                {
                    AH64.GetMessage($"{typeof(Bomber).Name} {message},AH64 отмените посадку\n");
                    B52.GetMessage($"{typeof(Bomber).Name} {message},B52 отмените посадку\n");
                }
            }
        }
    }
}
