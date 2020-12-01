using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes.Subsystems
{
    //Конкретный элемент сложной системы
    public class Provider
    {
        //Метод отправляет сообщение о том что товар доставлен на склад 
        public void Deliver()
        {
            Console.WriteLine("Поставщик доставил товар на склад");
        }
    }
}
