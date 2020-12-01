using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes.Subsystems
{
    //Конкретный элемент сложной системы
    public class Delivery
    {
        //Метод отправляет сообщение о том что товар доставлен
        public void DevileryGoods()
        {
            Console.WriteLine("Товар доставлен заказчику");
        }
    }
}
