using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.Abstract
{
    public abstract class Animal
    {
        //Создаём абстрактный класс с шаблонным методом
        public void TemplateMethod()
        {
            //Вызываем методы в шаблонном методе
            this.GoWalk();
            this.FindEat();
            this.Eat();
            this.CastVote();
            this.AvoidEnemy();
        }

        //Создаем основную логику в методах
        private void GoWalk()
        {
            Console.WriteLine("Животное пошло гулять");
        }

        //Создаем методы которые необходимо переопределить
        protected abstract void FindEat();

        //Создаем основную логику в методах
        private void Eat()
        {
            Console.WriteLine("Животное ест");
        }

        //Создаем методы которые необходимо переопределить
        protected abstract void CastVote();

        //Создаем методы которые необходимо переопределить
        protected virtual void AvoidEnemy() { }


    }
}
