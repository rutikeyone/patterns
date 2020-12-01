using System;
using System.Collections.Generic;
using CoRPattern.Abstract;

namespace CoRPattern.Classes
{
    public class Project
    {
        List<Developer> Developers = new();

        public void AddDevelop(Developer developer)
        {
            Developers.Add(developer);
        }


        public void Debug(AbstractClass handler)
        {
            Console.WriteLine("Результат запуска\n");

            for (int index = 0; index < Developers.Count; index++)
            {

                var Result = handler.Handle(Developers[index].Problem); //Используем цепочку обязанностей

                if (Result != null)
                {
                    Console.WriteLine($"Номер разработчика {index}, его результат : {Result}");
                }
                else
                {
                    Console.WriteLine("Нет результата\n");
                }
            }
        }
    }

}
