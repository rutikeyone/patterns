using System;
using AbstractFactory.AbstractFactory;

namespace AbstractFactory
{

    //Класс который будет пользоваться фабриками
    public class Customer
    {

        //Метод который будет пользоваться фабриками
        //Принимаем абстрактную фабрику чтобы можно было легко подменить одну конкретную фабрику на другую
        public void OrderFurniture(IAbstractFactory factory)
        {
            Console.WriteLine("Заказываю стул \n");
            factory.CreateChair(); //Создаем конкретные объекты
            Console.WriteLine("Заказываю стол \n");
            factory.CreateTable();//Создаем конкретные объекты
            Console.WriteLine("Заказываю диван \n");
            factory.CreateSofa();//Создаем конкретные объекты
        }
    }
}
