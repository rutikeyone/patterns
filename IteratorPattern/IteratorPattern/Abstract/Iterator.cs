using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Abstract
{
    //1. Необходимо создать интерфейс(Iterator) и наследовать его от IEnumerator
    public abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current(); //Возвращает текущий объект

        public abstract object Current(); 

        public abstract object GetKey(); //Получаем текущую позицию

        public abstract bool MoveNext(); //Перемещение по 

        public abstract void Reset();
    }
}
