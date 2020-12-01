using System;
using BuilderPattern.Classes;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder Builder = new();
            Director Director = new(Builder);
            Console.WriteLine("Standard usual house");
            Director.BuildUsualHouse();
            Console.WriteLine($"{Builder.GetProduct().ListParts()}\n");
            Console.WriteLine("Standard fancy statues");
            Director.BuildHouseWithFancyStatues();
            Console.WriteLine($"{Builder.GetProduct().ListParts()}\n");
            Console.WriteLine("Standard garage");
            Director.BuildHouseWithGarage();
            Console.WriteLine($"{Builder.GetProduct().ListParts()}\n");
            Console.WriteLine("Standard garden");
            Director.BuildHouseWithGarden();
            Console.WriteLine($"{Builder.GetProduct().ListParts()}\n");
            Console.WriteLine("Standard swimming pool");
            Director.BuildHouseWithSwimmingPool();
            Console.WriteLine($"{Builder.GetProduct().ListParts()}\n");
        }

        /*
         Паттерн строитель

         Позволяет создавать сложные объекты пошагово. Строитель позволяет использовать один и тот же код
         строительства для получения разных объектов.

         Зачем нужен данный паттерн:
         1.Когда вы хотите избавиться от большого количества конструкторов с разным количеством параметров
         2.Когда вы должны создавать разные представления одного и того же объекта 
         3.Когда нужно собирать сложные составные объекты

         Как реализовать данный паттерн:
         1.Убедитесь в том что создание объектом можно свести к общим шагам
         2.Опишите данные шаги в интерфейсе, метод сброса объекта
         3.Опишите код в объекте который должен быть создан(Коллекцию из частей и метод добавления части)
         4.Создайте конкретного строителя, реализуйте метод IBuilder
           *Не забывайте про метод получения объекта
         5.Подумайте о создание класса директора, его методы будут создавать разные конфигурации объектов
         6.Клиентский код должен будет создавать и объекты строителей, и объект директора.
         7.Результат строительства можно вернуть из директора, но только если метод возврата 
         продукта удалось поместить в общий интерфейс строителей.

         Плюсы:
         +Позволяет создавать продукты пошагово
         +Позволяет создавать разные объекты
         +Изолирует код создания объекта

         Минусы:
         -Усложняет архитектуру из-за введения дополнительных классов
         -Клиент привязан к конкретному классу строителей
         
         Вывод: Использовать если необходимо создавать сложный объект пошагово
                Использовать если необходимо избавиться от большого количества конструкторов
                Использовать если необходимо получать различные представления одного и того же объекта
        
         */
    }
}
