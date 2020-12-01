using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Classes
{
    //Класс находящийся в коллекции в Human
    public class Friend
    {
        private string FirstName { get; set; }

        private string LastName { get; set; }

        private int Age { get; set; }

        public Friend(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"Имя : {FirstName}, Фамилия : {LastName}, Возраст : {Age}";
        }
    }
}
