using System;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Classes
{
    //Конкретный адаптер, который реализует ITarget, адаптеров может быть несколько
    public class Adapter : ITarget
    {
       private readonly ISocketTypes Type; //Содержит ссылку на объекты которым необходим адаптер

        public Adapter(ISocketTypes type) //Агрегация
        {
            Type = type;
        }

        public string UseOutlet() //Реализует методы, такие же как в классах сервиса
        {
            return this.Type.UseSpecicialOutlet();
        }
    }
}
