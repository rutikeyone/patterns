using System;
using CoRPattern.Abstract;

namespace CoRPattern.Classes.DevelopmentStates
{
    //Создадим конкретные цепи
    public class HudeProblem : AbstractClass
    {
        public override object Handle(LevelProblem problem)
        {
           if(problem == LevelProblem.Hight) //реализуем логику обработки запроса
            {
                return "Проблема серьезная, погуглю, поспрашиваю у знакомых\n";
           }
            //Если мы не можем обработать запрос то передаём его следущей цепи.
            else
            {
                return base.Handle(problem);
           }
        }
    }
}
