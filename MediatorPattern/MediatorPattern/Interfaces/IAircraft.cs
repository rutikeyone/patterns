using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Interfaces
{
    interface IAircraft
    {
        void TakeOff();

        void GetMessage(string message);
    }
}
