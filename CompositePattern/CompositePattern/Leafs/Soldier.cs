using System;
using System.Collections.Generic;
using CompositePattern.Components;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Leafs
{
    //Простой класс, данный класс не имеет других вложенных объектов и выполняют какую-то работу
    public class Soldier : Component
    {
        //Даем понять клиенскому классу содержит ли данные объект вложенные объекты
        protected override bool IsComposite { get; set; } = false;
        //Работа выполняется вот тут
        public override void MobilizationOrder()
        {
            Console.WriteLine("Солдат выполняет приказ");
        }
    }
}
