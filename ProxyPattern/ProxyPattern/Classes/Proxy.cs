using System;
using ProxyPattern.Interfaces;


namespace ProxyPattern.Classes
{
    //Заместитель объекта Cash, он определяет логику вызова метода Cash и что нужно сделать до и сделать после 
    public class Proxy : IPayment
    {
        //Должен содержать ссылку на сервисный объект 
        private Cash Cash { get; set; }

        //Инициализируем ссылку на объект
        public Proxy(int accountAmount)
        {
            Cash = new(accountAmount);
        }

        //Реализуем логику, что вызвать до, что вызвать после
        public void Pay(int amount)
        {
            if(this.Cash != null)
            {
                BeforePay();
                this.Cash.Pay(amount);
                AfterPay();
            }
        }

        //Метод определяющий какую-то логику, который вызывается до 
        private void BeforePay()
        {
            Console.WriteLine("До оплаты");
        }
        //Метод определяющий какую-то логику, который вызывается после
        private void AfterPay()
        {
            Console.WriteLine("После оплаты");
        }
    }
}
