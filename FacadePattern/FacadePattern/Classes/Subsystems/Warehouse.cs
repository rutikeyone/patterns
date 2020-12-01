using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes.Subsystems
{
    //Конкретный элемент сложной системы
    public class Warehouse
    {
        //Метод отправляет сообщение о том что заказ завезен на склад
        public void ReceiveGoods()
        {
            Console.WriteLine("На склад был завезён товар");
        }
    }
}
