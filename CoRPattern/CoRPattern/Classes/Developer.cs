using CoRPattern.Abstract;
using System;

namespace CoRPattern.Classes
{
    public class Developer
    {
        public LevelProblem Problem { get; private set; }

        public Developer(LevelProblem problem)
        {
            Problem = problem;
        }
    }
}
