using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.VictorianFurniture
{
    //Конкретный вид дивана
    public class VictorianSofa : IAbstractSofa
    {
        public TypesFurniture TypeSofa { get; set; } = TypesFurniture.Victorian;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public VictorianSofa()
        {
            Console.WriteLine("Создание дивана в викторианском стиле\n");
        }
    }
}
