using System;
using FacadePattern.Classes.FacadeClasses;

namespace FacadePattern.Classes
{
    //Класс предоставляющий бизнез логику
    public class Client
    {
        //Метод для заказа ноутбука который принимает класс фасада
        public void OrderLaptop(Facade facade)
        {
            facade.MakeOrder();
        }
    }
}
