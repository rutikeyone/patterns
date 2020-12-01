using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractProducts
{
    //Интерфейс общий для всех видов диванов
    public interface IAbstractSofa
    {
        TypesFurniture TypeSofa { get; set; }
    }
}
