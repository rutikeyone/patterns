using System;
using CoRPattern.Interfaces;

namespace CoRPattern.Abstract
{
    // Создадим абстрактный класс.
    public class AbstractClass : IHandler
    {
        IHandler NextHandler; //Он нужен для того чтобы хранить в себе ссылку на новый элемент цепи.
        public virtual object Handle(LevelProblem problem)
        {
            if (this.NextHandler != null)
            {
               return this.NextHandler.Handle(problem);
            }
            else
            {
                return $"Not next chain\n";
            }
        }

        public IHandler SetNext(IHandler handler) //Абстрактный класс сождержит в себе логику добавления нового элемента цепи.
        {
            this.NextHandler = handler;
            return handler;
        }
    }
}
