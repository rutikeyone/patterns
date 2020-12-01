using Strategy.Interfaces;
using System;

namespace Strategy.Classes
{
    public class Cow : IHomeAnimal
    {
        public int ID { get; set; }
        public Cow(int id)
        {
            ID = id;
        }

        public void CastVote(string id)
        {
            if (int.TryParse(id, out int result) && result == ID)
            {
                Console.WriteLine($"{ID} произнесла муу");
            }
        }

        public void ComeHome()
        {
            Console.WriteLine($"{ID} пришела домой");
        }

        public void Eat()
        {
            Console.WriteLine($"{ID} ест");
        }

        public void GoOutSide()
        {
            Console.WriteLine($"{ID} пошел гулять");
        }
    }
}
