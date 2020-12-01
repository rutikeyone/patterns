using IteratorPattern.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Classes
{
    //Human наследуем от Iterator и реализуем реобходимую логику
    public class Human : IteratorAggregate
    {
        private List<Friend> Friends = new List<Friend>(); //Создаём коллекцию которую необходимо перебрать
        public bool IsNeedReverse = default; //Необходимо ли перебирать с конца

        public Human()
        {

        }

        public Human(bool isNeedReverse)
        {
            IsNeedReverse = isNeedReverse; //Инициализируем 
        }

        public void AddItem(Friend friend) //Мы сделали List private поэтому создаем метод для добавления друзей
        {
            Friends.Add(friend);
        }

        public List<Friend> GetItems() //Мы сделали List private поэтому создаем метод для получения Count()
        {
            return Friends;
        }

        public override IEnumerator GetEnumerator() //Метод будет вызываться при переборе
        {

            return new ConcreteIterator(this, IsNeedReverse); //Вызываем конкретный итератор

        }
    }
}
