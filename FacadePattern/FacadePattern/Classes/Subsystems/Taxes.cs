using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes.Subsystems
{
    //Конкретный элемент сложной системы
    public class Taxes
    {
        //Метод отправляет сообщение о том что заказчик оплатил налоги
        public void PayTaxes()
        {
            Console.WriteLine("Заказчик оплатил налоги на товар");
        }
    }
}
