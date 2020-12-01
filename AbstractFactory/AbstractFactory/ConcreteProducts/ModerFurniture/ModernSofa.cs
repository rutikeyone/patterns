using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.ModerFurniture
{
    //Конкретный вид дивана
    public class ModernSofa : IAbstractSofa
    {
        public TypesFurniture TypeSofa { get; set; } = TypesFurniture.Modern;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public ModernSofa()
        {
            Console.WriteLine("Создание дивана в современном стиле\n");
        }
    }
}
