using System;
using AbstractFactory.AbstractProducts;
namespace AbstractFactory.ConcreteProducts.Artdecor
{
    //Конкретный вид стола
    public class ArtdecorTable : IAbstractTable
    {
        public TypesFurniture TypeTable { get; set; } = TypesFurniture.Artdecor;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public ArtdecorTable()
        {
            Console.WriteLine("Создание стола в аркдекор стиле\n");
        }
    }
}
