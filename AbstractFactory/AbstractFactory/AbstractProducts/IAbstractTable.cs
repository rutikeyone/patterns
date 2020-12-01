using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractProducts
{
    //Интерфейс общий для всех видов столов
    public interface IAbstractTable
    {
        TypesFurniture TypeTable { get; set; }
    }
}
