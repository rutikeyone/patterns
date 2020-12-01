using System;
using ProxyPattern.Interfaces;

namespace ProxyPattern.Classes
{
    //Реальный объект который содержит в себе какую-то логику
    public class Cash : IPayment
    {
        //Сумма на аккаунте
        private int AccountAmount { get; set; }

        //Конструктор
        public Cash(int accountAmount)
        {
            AccountAmount = accountAmount;
        }

        //В данном методе реализуем логику
        public void Pay(int amount)
        {
            if (AccountAmount - amount > 0)
            {
                Console.WriteLine($"Оплата прошла успешно, оставшееся сумма : {AccountAmount - amount} ");
            }
            else
            {
                Console.WriteLine("Недостаточно средст для оплаты");
            }
        }
    }
}
