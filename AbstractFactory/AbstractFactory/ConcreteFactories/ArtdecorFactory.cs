using System;
using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProducts;
using AbstractFactory.ConcreteProducts.Artdecor;

namespace AbstractFactory.ConcreteFactories
{
    //Конкретная фабрика, которая создает мебель в стиле артдекор
    public class ArtdecorFactory : IAbstractFactory
    {
        public IAbstractChair CreateChair() //Создание стула
        {
            return new ArtdecorChair();
        }

        public IAbstractSofa CreateSofa() //Создание дивана
        {
            return new ArtdecorSofa();
        }

        public IAbstractTable CreateTable() //Создание стола
        {
            return new ArtdecorTable();
        }
    }
}
