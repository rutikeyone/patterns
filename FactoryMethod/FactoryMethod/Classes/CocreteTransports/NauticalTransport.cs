using System;
using FactoryMethod.Interfaces;

namespace FactoryMethod.Classes.CocreteTransports
{
    //Конретный вид "продукта" транспорта
    public class NauticalTransport : ITransport
    {
        public TypesTransport Type { get; set; } = TypesTransport.Nautical;
    }
}
