using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Interfaces
{
    // 2.Создайте интерфейс элементов, которое будут посещать
    public interface IComponent
    {
        void Accept(IVisitor visitor); // Объявите метод принятия 
    }
}
