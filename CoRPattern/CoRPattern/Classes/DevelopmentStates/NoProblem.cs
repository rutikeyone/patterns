using System;
using CoRPattern.Abstract;

namespace CoRPattern.Classes.DevelopmentStates
{
    //Создадим конкретные цепи
    public class NoProblem : AbstractClass
    {
        public override object Handle(LevelProblem problem)
        {
            if (problem == LevelProblem.NoProblem) //реализуем логику обработки запроса
            {
                return $"Отлично, проблем нет, продолжаю разработку\n";
            }
            //Если мы не можем обработать запрос то передаём его следущей цепи.
            else
            {
                return base.Handle(problem);
            }
        }
    }
}
