using System;
using System.Collections.Generic;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Classes
{
    //Создадим метод(лучше в отдельном классе) который будет принимать классы которые необходимо посетить и посетителя
    public class Teamlead
    {
        public static void SendEmployees(List<IComponent> employees, IVisitor visitor)
        {
            //Через foreach посещаем каждый класс
            foreach (var employee in employees)
            {
                employee.Accept(visitor);
            }
        }

    }
}
