using BuilderPattern.Classes;
using System;

namespace BuilderPattern.Interfaces
{
    public interface IBuilder
    {
        void Reset();
        void BuildUsualHouse();
        void BuildHouseWithGarage();
        void BuildHouseWithFancyStatues();
        void BuildHouseWithSwimmingPool();
        void BuildHouseWithGarden();
        Product GetProduct();
    }
}
