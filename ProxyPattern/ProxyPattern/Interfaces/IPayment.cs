using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Interfaces
{
    //Общий интерфейс для реального объекта и его заместителя
    public interface IPayment
    {
        //Какая-то логика сервисного объекта
        void Pay(int amount);
    }
}
