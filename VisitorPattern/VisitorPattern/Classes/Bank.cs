using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Classes
{
    public enum ScaleOfHazard
    {
        Low,
        Medium,
        Hight
    }

    //Реализуйте интерфейс IComponent
    public class Bank : IComponent
    {
        public ScaleOfHazard Scale { get; private set; }
        public int Revenue { get; private set; }
        public Bank(ScaleOfHazard scale, int revenue)
        {
            Scale = scale;
            Revenue = revenue;
            
        }

        public void Accept(IVisitor visitor) //Реализуйте метод принятия в конкретных классах
        {
            visitor.VisitBank(this);
        }
    }
}
