using System;
using AbstractFactory.AbstractProducts;

namespace AbstractFactory.AbstractFactory
{
    //Интерфейс, общий для всех конкретных фабрик
    public interface IAbstractFactory
    {
        IAbstractChair CreateChair();//Создаем методы которые будут в конкретных фабриках создавать конкретные классы
        IAbstractSofa CreateSofa();//Создаем методы которые будут в конкретных фабриках создавать конкретные классы
        IAbstractTable CreateTable();//Создаем методы которые будут в конкретных фабриках создавать конкретные классы
    }
}
