using System;
using AdapterPattern.Interfaces;

namespace AdapterPattern.Classes.Adaptee
{
    //Конкретный сервис, класс который нельзя менять и для решения данной проблемы необходим адаптер
    public class TypeK : ISocketTypes
    {
        public string UseSpecicialOutlet()
        {
            return "Use type K";
        }
    }
}
