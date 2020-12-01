using AdapterPattern.Interfaces;
using System;

namespace AdapterPattern.Classes.Adaptee
{
    //Конкретный сервис, класс который нельзя менять и для решения данной проблемы необходим адаптер
    public class TypeD : ISocketTypes
    {
        public string UseSpecicialOutlet()
        {
            return "Use type D";
        }
    }
}
