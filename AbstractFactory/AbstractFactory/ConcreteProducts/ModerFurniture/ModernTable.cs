using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.ModerFurniture
{
    //Конкретный вид стола
    class ModernTable : IAbstractTable
    {
        public TypesFurniture TypeTable { get; set; } = TypesFurniture.Modern;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public ModernTable()
        {
            Console.WriteLine("Создание стола в современном стиле\n");
        }
    }
}
