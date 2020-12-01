namespace Strategy.Interfaces
{
    interface IHomeAnimal
    {
        void CastVote(string nickname);
        void GoOutSide();
        void ComeHome();
        void Eat();
    }
}
