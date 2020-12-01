using CompositePattern.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Composites
{
    /*Сложный составной объект, который содержить в себе простые объекты
      Обычно такие классы делегируют свою работу потомкам
     */
    public class CommanderInChief : Component
    {
        //Вот тут содержаться ссылки на простые и составные объекты
        private List<Component> RegimentCommanders = new();

        //Даем понять клиенскому классу содержит ли данные объект вложенные объекты
        protected override bool IsComposite { get; set; } = true;
        //Метод для добавления вложенных объектов
        public override void Add(Component component)
        {
            this.RegimentCommanders.Add(component);
        }

        //Метод для удаления вложенных объектов
        public override void Remove(Component component)
        {
            this.RegimentCommanders.Remove(component);
        }
        //Составной объект выполняет свою логику по особому. Он вызывает логику у своих потомков и суммирует их результаты.
        public override void MobilizationOrder()
        {
            if (this.IsComposite)
            {
                Console.WriteLine("Главнокомандующий отдал приказ о мобилизации");
                //Обходим по объектам потомков
                foreach (var commander in RegimentCommanders)
                {
                    commander.MobilizationOrder();
                }
            }
        }
    }
}
