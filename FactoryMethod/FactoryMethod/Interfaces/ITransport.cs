using System;

namespace FactoryMethod.Interfaces
{
    //Общий интерфейс для всех видов "продуктов" в нашем случае видом транспорта
    public interface ITransport
    {
        public TypesTransport Type { get; set; }

    }
}
