using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Classes.Subsystems
{
    //Конкретный элемент сложной системы
    public class Package
    {
        //Метод отправляет сообщение о том что произошла упаковка товара
        public void PackGoods()
        {
            Console.WriteLine("Произошла упаковка товара");
        }
    }
}
