using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.Artdecor
{
    //Конкретный вид дивана
    public class ArtdecorSofa : IAbstractSofa
    {
        public TypesFurniture TypeSofa { get; set; } = TypesFurniture.Artdecor;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public ArtdecorSofa()
        {
            Console.WriteLine("Создание дивана в аркдекор стиле\n");
        }
    }
}
