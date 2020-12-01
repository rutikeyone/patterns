using System;
using IteratorPattern.Classes;
using IteratorPattern.Extentions;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Andrew = new(false);
            Andrew.AddItem(new Friend("Александр", "Парфинович", 18));
            Andrew.AddItem(new Friend("Никита", "Родионов", 18));
            Andrew.AddItem(new Friend("Ткаченко", "Андрей", 18));

            foreach(var friend in Andrew)
            {
                Console.WriteLine(friend);
            }

            foreach(var item in 1..15)
            {
                Console.WriteLine(item);
            }
        }


        /*
         
         Паттерн итератор

         Зачем нужен данный паттерн:
         1. Когда есть сложная структура данных и её необходимо скрыть
         2. Когда необходимо иметь несколько способов обхода одной и той же структуры данных
         3. Когда необходимо реализовать логику обхода данных с единым интерфейсом и инкапсульровать логику
         

         Шаги реализации
         
         1. Необходимо создать интерфейс(Iterator) и наследовать его от IEnumerator
         2. Создать класс (IteratorAggregate) который наследуется от IEnumerable для работы с IEnumerator
         3. Реализовать конкретную логику перебора коллекции
         4. Создаём два класса Human и Friend
         5. Human наследуем от Iterator и реализуем необходимую логику

         
         Плюсы :
         +Позволяет перемещаться по коллекции с начала и конца 
         +Реализация различных подходов перебора данных
         +Упрощает классы хранения данных так как логика выносится отдельно
         
         Минусы :
         -Не всегда оправдан
         
         Вывод: Использовать когда необходимо создать логику перебора данных вне класса 
          
         
         */
    }
}
