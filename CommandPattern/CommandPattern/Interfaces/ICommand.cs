using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Interfaces
{
    /*1. Создайте интерфейс ICommand который будет иметь метод принятия 
     и передачи данных или другой логики от отправителя к получателю*/
    public interface ICommand
    {
        void Execute();
    }
}
