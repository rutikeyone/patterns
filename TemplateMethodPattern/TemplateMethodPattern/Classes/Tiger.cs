using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Classes
{
    //Наследуем абстраткный класс и реализуем к конкретном классе
    public class Tiger : Animal
    {
        protected override void CastVote()
        {
            Console.WriteLine("Тррр");
        }

        protected override void FindEat()
        {
            Console.WriteLine("Тигр охотиться");
        }
    }
}
