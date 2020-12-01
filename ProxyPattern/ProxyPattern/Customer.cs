using System;
using ProxyPattern.Interfaces;

namespace ProxyPattern
{
    //Клиенский класс
    public class Customer
    {
        //Метод который принимает либо сервисный объект либо заместителя
        public void MakeOrder(IPayment payment, int amount)
        {
            //Вызываем метод 
            payment.Pay(amount);
        }
    }
}
