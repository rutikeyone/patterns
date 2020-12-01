using System;
using CommandPattern.Classes;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    /*4. Создайте класс отправителя, который будет содержать в себе ссылку на ICommand и логику
             вызова определенной команды */
    public class Customer
    {
        ICommand OrderCommand;

        public void SetCommand(ICommand orderCommand)
        {
            OrderCommand = orderCommand;
        }


        public void ToOrder()
        {
            if(OrderCommand is OrderSoup)
            {
                Console.WriteLine("To order soup \n");
                this.OrderCommand.Execute();
            }

            if(OrderCommand is OrderFries){
                Console.WriteLine("To order fries \n");
                this.OrderCommand.Execute();
            }
        }

    }
}
