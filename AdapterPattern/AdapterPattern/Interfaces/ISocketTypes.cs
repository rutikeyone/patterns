using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interfaces
{
    //Интерфейс для всех типов розеток, не имеет отношения к паттерну адаптер
    public interface ISocketTypes
    {
        string UseSpecicialOutlet();
    }
}
