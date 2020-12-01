using Strategy.Interfaces;
using System;

namespace Strategy.Classes
{
    class Dog : IHomeAnimal
    {
        public string NickName { get; set; }
        public Dog(string nickname)
        {
           NickName = nickname;
        }

        public void CastVote(string name)
        {
            if (NickName == name)
            {
                Console.WriteLine("Гав");
            }
        }

        public void ComeHome()
        {
            Console.WriteLine($"{NickName} пришел домой");
        }

        public void Eat()
        {
            Console.WriteLine($"{NickName} ест");
        }

        public void GoOutSide()
        {
            Console.WriteLine($"{NickName} пошел гулять");
        }
    }
}
