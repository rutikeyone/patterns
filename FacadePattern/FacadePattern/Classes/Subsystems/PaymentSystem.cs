using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes.Subsystems
{
    //Конкретный элемент сложной системы
    public class PaymentSystem
    {
        //Метод отправляет сообщение о том что заказчик оплатил товар
        public void PayGoods()
        {
            Console.WriteLine("Заказчик оплатил товар");
        }
    }
}
