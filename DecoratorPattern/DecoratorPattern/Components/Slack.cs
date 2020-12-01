using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Components
{
    //Конкретные компоненты, которые предоставляют реализацию логики по умолчанию (Sms,Facebook,Slack) 
    public class Slack : Notifier
    {
        public override string Notify(string message)
        {
            return "Slack оповещение : {message}";
        }
    }
}
