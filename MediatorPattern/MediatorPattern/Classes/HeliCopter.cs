using MediatorPattern.BaseClasses;
using MediatorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Classes
{
    //Создаём конкретные классы которые реализуют какую-нибудь логику и наследуем её от AirCraft(абстрактного класса)
    class HeliCopter : Aircraft, IAircraft
    {
        public void GetMessage(string message)
        {
            Console.WriteLine(message);
        }

        //В методах конкретного класса мы вызываем Notify и уведомляем о действии
        public void TakeOff()
        {
            this.Mediator.Notify(this, "взлетает");
        }


    }
}
