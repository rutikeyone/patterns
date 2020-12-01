using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Classes
{
    public enum LevelAffluence
    {
        Low,
        Medium,
        Hight
    }

    //Реализуйте интерфейс IComponent
    public class Family : IComponent
    {
        public LevelAffluence Level { get; private set; }
        public bool IsReadyGetInsurance { get; private set; }
        public Family(LevelAffluence levelAffluence, bool isReadyGetInsurance)
        {
            Level = levelAffluence;
            IsReadyGetInsurance = isReadyGetInsurance;
        }

        public void Accept(IVisitor visitor)//Реализуйте метод принятия в конкретных классах
        {
            visitor.VisitFamily(this);
        }
    }
}
