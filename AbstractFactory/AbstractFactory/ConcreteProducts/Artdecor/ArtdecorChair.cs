using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.Artdecor
{
    //Конкретный вид стула
    public class ArtdecorChair : IAbstractChair
    {
        public TypesFurniture TypeChair { get; set; } = TypesFurniture.Artdecor;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public ArtdecorChair()
        {
            Console.WriteLine("Создание стула в аркдекор стиле\n");
        }
    }
}
