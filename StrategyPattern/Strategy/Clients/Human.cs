using Strategy.Classes;
using Strategy.Interfaces;

namespace Strategy.Clients
{
    class Human
    {
        IHomeAnimal HomeAnimal;

        public Human(IHomeAnimal homeAnimal)
        {
            this.HomeAnimal = homeAnimal;
        }
        public void PlayWithTheAnimal()
        {
            this.HomeAnimal.Eat();
            this.HomeAnimal.CastVote("Рыжик");
        }
    }
}
