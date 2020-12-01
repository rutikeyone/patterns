using FactoryMethod.Abstract;
using FactoryMethod.Classes.CocreteTransports;
using FactoryMethod.Interfaces;
using System;



namespace FactoryMethod.Classes.CocreteCreators
{
    //Конкретный вид фабрики которая создает конкретный "продукт"
    public class CreatorRailWayTransport : Creator
    {
        //Фабричный метод который создает конкретный "продукт"
        public override ITransport CreateTransport()
        {
            return new RailWayTransport();
        }
    }
}
