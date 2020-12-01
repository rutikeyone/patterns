using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.ModerFurniture
{
    //Конкретный вид стула
    public class ModernChair : IAbstractChair
    {
        public TypesFurniture TypeChair { get; set; } = TypesFurniture.Modern;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public ModernChair()
        {
            Console.WriteLine("Создание стула в современном стиле\n");
        }
    }
}
