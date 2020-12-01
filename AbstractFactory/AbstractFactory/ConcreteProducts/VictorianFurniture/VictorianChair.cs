using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteProducts.VictorianFurniture
{
    //Конкретный вид стула
    public class VictorianChair : IAbstractChair
    {
        public TypesFurniture TypeChair { get; set; } = TypesFurniture.Victorian;

        //Тут мы оповещаем себя какой объект создается (для большего понимания что происходит)
        public VictorianChair()
        {
            Console.WriteLine("Создание стула в викторианском стиле \n");
        }
    }
}
