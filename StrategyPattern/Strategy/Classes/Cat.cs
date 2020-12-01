using Strategy.Interfaces;
using System;

namespace Strategy.Classes
{
    class Cat : IHomeAnimal
    {
        private string Name { get; set; }
        public Cat(string nickname)
        {
            Name = nickname;
        }

        public void CastVote(string nickname)
        {
           if(Name == nickname)
            {
                Console.WriteLine("Мяу");
            }
        }

        public void ComeHome()
        {
            Console.WriteLine($"{Name} пришел домой");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} ест");
        }

        public void GoOutSide()
        {
            Console.WriteLine($"{Name} пошел гулять");
        }
    }
}
