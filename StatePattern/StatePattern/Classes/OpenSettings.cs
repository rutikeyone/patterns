using StatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Classes
{
    //Создадь конкретные классы которые по-своему будут реализовывать логику состояния
    public class OpenSettings : State
    {
        public override void PressButton()
        {
            Console.WriteLine("Открыть настройки\n");
        }
    }
}
