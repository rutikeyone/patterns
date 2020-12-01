using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod.Abstract
{
    //Астрактный класс для конкретных создателей
    public abstract class Creator
    {
      //Он содержит в себе метод для создания конкретных "продуктов" в подклассах
      public abstract ITransport CreateTransport();


    }
}
