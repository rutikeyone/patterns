using System;
using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts.VictorianFurniture;

namespace AbstractFactory.ConcreteFactories
{
    //Конкретная фабрика, которая создает мебель в викторианском стиле
    public class VictorianFactory : IAbstractFactory
    {
        public IAbstractChair CreateChair() //Создание стула
        {
            return new VictorianChair();
        }

        public IAbstractSofa CreateSofa() //Создание дивана
        {
            return new VictorianSofa();
        }

        public IAbstractTable CreateTable() //Создание стола
        {
            return new VictorianTable();
        }
    }
}
