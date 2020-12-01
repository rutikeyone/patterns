using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.VictorianFurniture
{
   //Конкретный вид стола
    public class VictorianTable : IAbstractTable
    {
        public TypesFurniture TypeTable { get; set; } = TypesFurniture.Victorian;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public VictorianTable()
        {
            Console.WriteLine("Создание стола в викторианском стиле\n");
        }
    }
}
