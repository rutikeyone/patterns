using FactoryMethod.Abstract;
using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod
{
    //Класс который содержит в себе какую-то бизнес логику
    public class Cargo
    {
        //Метод который принимает в себя конкретную фабрику
        public void Shipping(Creator creator)
        {
            Console.WriteLine("I start shipping the product");
            Console.WriteLine($"Type transport : {creator.CreateTransport().GetType()}"); //Создаем конкретный объект
        }
    }
}
