using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Classes
{
    public class NaiveSingleton //Наивный одиночка, главным недостатком является отсутствие поддержки многопоточности
    {
        private NaiveSingleton() { } //Скрываем конструктор

        private static NaiveSingleton _Singleton; //Создаем единственный объект

        public int Password {get; set; } = 1234; //Значение для проверки того что класс работает 



        public static NaiveSingleton GetInstance() //Метод для создание единственного объекта
        {
            if (_Singleton == null) //Если объект не создан, создаем его иначе просто получем объект
            {
                _Singleton = new NaiveSingleton();
            }

            return _Singleton;
        }
    }
}
