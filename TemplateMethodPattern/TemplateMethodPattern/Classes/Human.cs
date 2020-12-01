using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Abstract;

namespace TemplateMethodPattern.Classes
{
    //Создаем класс (Client) в котором принимаем абстрактный класс 
    public class Human
    {
        //вызываем шаблонный метод
        public void SomeWork(Animal animal)
        {
            animal.TemplateMethod();
        }
    }
}
