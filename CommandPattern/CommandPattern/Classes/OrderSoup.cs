using CommandPattern.Interfaces;
using System;

namespace CommandPattern.Classes
{
    //3. Создайте конкретные команды
    public class OrderSoup : Waiter, ICommand
    {
        Cook Cook;
        public void Execute()
        {
            Console.WriteLine("Waiter transfer order soup \n");
            Cook = new();
            Cook.GetOrder(Menu.Soup);
        }
    }
}
