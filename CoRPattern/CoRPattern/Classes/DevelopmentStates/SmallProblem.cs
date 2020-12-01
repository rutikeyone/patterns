using System;
using CoRPattern.Abstract;

namespace CoRPattern.Classes.DevelopmentStates
{
    //Создадим конкретные цепи
    public class SmallProblem : AbstractClass
    {
        public override object Handle(LevelProblem problem)
        {
            if (problem == LevelProblem.Low) //реализуем логику обработки запроса
            {
                return "Есть небольшие проблемы, попробую решить их и продолжу разработку\n";
            }
            //Если мы не можем обработать запрос то передаём его следущей цепи.
            else
            {
                return base.Handle(problem);
            }
              
        }
    }
}
