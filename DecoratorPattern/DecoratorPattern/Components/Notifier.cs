using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Components
{
    //Базовый класс компонента, определяет логику которая будет изменяться в декораторах
    public abstract class Notifier
    {
        public abstract string Notify(string message);
    }
}
