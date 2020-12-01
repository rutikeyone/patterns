using MediatorPattern.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Interfaces
{
    //Необходимо создать интерфейс IMediator и метод(Notify) в котором будет происходить взаимодействие(методов может быть несколько)
    interface IMediator
    {
        void Notify(Aircraft aircraft, string message);
    }
}
