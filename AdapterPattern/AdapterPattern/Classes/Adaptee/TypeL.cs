using System;
using AdapterPattern.Interfaces;
namespace AdapterPattern.Classes.Adaptee
{
    public class TypeL : ISocketTypes
    {
        //Конкретный сервис, класс который нельзя менять и для решения данной проблемы необходим адаптер
        public string UseSpecicialOutlet()
        {
            return "Use type L";
        }
    }
}
