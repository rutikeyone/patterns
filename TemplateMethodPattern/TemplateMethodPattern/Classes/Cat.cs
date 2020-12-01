using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Classes
{
    //Наследуем абстраткный класс и реализуем к конкретном классе
    public class Cat : Animal
    {
        protected override void CastVote()
        {
            Console.WriteLine("Мяу");
        }

        protected override void FindEat()
        {
            Console.WriteLine("Кот охотиться на мышей");
        }

        protected override void AvoidEnemy()
        {
            Console.WriteLine("Кот убегает от собаки");
        }
    }
}
