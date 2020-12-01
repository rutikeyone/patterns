using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Classes
{
    public class MultiThreadsSingleton //Реализация Singleton для многопоточности
    {
        private MultiThreadsSingleton() { } //Так же закрываем конструктор для того чтобы случайно не создался новый объект

        private static MultiThreadsSingleton _Singleton; //Создаем единственный объект

        public string Value { get; private set; } //Значение для проверки того что класс работает 
         
        private static readonly object Lock = new(); //Поле для синхронизации потоков

        public static MultiThreadsSingleton GetInstance(string value) //Метод для создание единственного объекта
        {
            //Опишу работу нескольких потоков
            //Допустим у нас запущено два потока(поток1, поток2)
            //Условие для того чтобы потоки сразу не ожидали около lock
            if (_Singleton == null)
            {
                /*Допустим программа запущена первый раз
                 поток1 - самый быстрый поток 
                 поток2 - ожидает, когда поток1 выходит из lock, поток 2 проверяет _Singleton == null
                 так как поток1 создал объект то пробускаем это условие и просто возвращаем объект
                 
                 */
                lock(Lock){
                    //поток1 проходит дальше и ставит блокировку
                    if (_Singleton == null) 
                    {
                        _Singleton = new MultiThreadsSingleton(); //(поток1) программа запущена первый раз, объект не создан поэтому создадим его 
                        _Singleton.Value = value; //(поток1) установим значение для проверки работоспособности
                    }
                    
                }
            }

            return _Singleton; //Возращаем единственный объект
        }

    }
}
