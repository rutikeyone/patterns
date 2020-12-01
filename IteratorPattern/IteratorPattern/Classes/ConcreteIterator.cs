using IteratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Classes
{
    //3. Реализовать конкретную логику перебора коллекции
    public class ConcreteIterator : Iterator
    {
        private Human Andrew; //Создаём объект в котором необходимо перебрать данные
        private int Position = -1; //Позиция для перебора
        private bool IsReverse = default; //Необходимо ли перебирать объекты с конца
        public ConcreteIterator(Human human, bool isReverse) //Конструктор
        {
            Andrew = human; //Инициализируем поля
            IsReverse = isReverse; //Инициализируем поля

            if (IsReverse) //Если надо перебирать с конца то устанавливаем начальную позицию с конца
            {
                this.Position = this.Andrew.GetItems().Count();
            }
        }
        //Метод получения текущего объекта
        public override object Current()
        {
            return this.Andrew.GetItems()[Position];
        }

        //Получить значения position
        public override object GetKey()
        {
            return this.Position;
        }
        //Перемещение по коллекции
        public override bool MoveNext()
        {
            //Если нужно перебирать с конца то с каждой итерацией отнимаем один иначе прибавляем 
            int Updated = this.Position + (this.IsReverse ? -1 : 1);
            if(Updated >= 0 && Updated < this.Andrew.GetItems().Count()) //Условие
            {
                this.Position = Updated;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Возвращение к началу итерации
        public override void Reset()
        {
            this.Position = this.IsReverse ? this.Andrew.GetItems().Count() - 1 : 0;
        }
    }
}
