using FactoryMethod.Interfaces;
using System;


namespace FactoryMethod.Classes.CocreteTransports
{
    //Конретный вид "продукта" транспорта
    public class RoadTransport : ITransport
    {
        public TypesTransport Type { get; set; } = TypesTransport.Road;

    }
}
