using CommandPattern.Interfaces;
using System;


namespace CommandPattern.Classes
{
    //3. Создайте конкретные команды
    public class OrderFries : Waiter, ICommand
    {
        Cook Cook;
        public void Execute()
        {
            Console.WriteLine("Waiter transfer order fries \n");
            Cook = new();
            Cook.GetOrder(Menu.Fries);
        }
    }
}
