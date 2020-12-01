using System;
using AbstractFactory.ConcreteProducts.ModerFurniture;
using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.ConcreteFactories
{
    //Конкретная фабрика, которая создает мебель в современном стиле
    public class ModernFactory : IAbstractFactory
    {
        public IAbstractChair CreateChair() //Создание стула
        {
            return new ModernChair();
        }

        public IAbstractSofa CreateSofa() //Создание дивана
        {
            return new ModernSofa();
        }

        public IAbstractTable CreateTable() //Создание стола
        {
            return new ModernTable();
        }
    }
}
