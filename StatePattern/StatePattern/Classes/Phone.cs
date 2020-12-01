using System;
using StatePattern.Abstract;

namespace StatePattern.Classes
{
    
    //3.Создать объект который будет менять свое поведение в зависимости от состояния
    public class Phone
    {
        State State = null; //Он хранит в себе ссылку на состояние 

        public Phone(State state)
        {
            this.TransitionTo(state);
        }

        public void TransitionTo(State state) //Имеет метод для инициализации состояния (State State)
        {
            Console.WriteLine($"Установить новое состояни, type class : {state.GetType().Name}\n");
            this.State = state;
            this.State.SetPhone(this);
        }

        public void PressButton() //Конкретный метод который будет менять свою логику взависимости от состояния объекта 
        {
            this.State.PressButton();
        }


    }
}
