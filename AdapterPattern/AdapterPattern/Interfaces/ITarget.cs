using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Interfaces
{
    //Клиенский интерфейс, каждый конкретный адаптер должен реализовывать его
    public interface ITarget
    {
        string UseOutlet();
    }
}
