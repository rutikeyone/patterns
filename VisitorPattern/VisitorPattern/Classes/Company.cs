using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Classes
{
    public enum LevelPrestige
    {
        Low,
        Medium,
        Hight
    }

    //Реализуйте интерфейс IComponent
    public class Company : IComponent
    {
        public LevelPrestige Prestige { get; private set; }
        public int Revenue { get; private set; }

        public Company(LevelPrestige prestige, int revenue)
        {
            Prestige = prestige;
            Revenue = revenue;
        }

        public void Accept(IVisitor visitor) //Реализуйте метод принятия в конкретных классах
        {
            visitor.VisitCompany(this);
        }
    }
}
