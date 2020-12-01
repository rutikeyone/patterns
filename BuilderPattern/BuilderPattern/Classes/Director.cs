using BuilderPattern.Interfaces;
using System;

namespace BuilderPattern.Classes
{
    public class Director
    {
        private IBuilder Builder;

        public Director(IBuilder builder)
        {
            Builder = builder;
        }

        public void BuildUsualHouse()
        {
            this.Builder.BuildUsualHouse();
        }

        public void BuildHouseWithGarage()
        {
            this.Builder.BuildUsualHouse();
            this.Builder.BuildHouseWithGarage();
        }

        public void BuildHouseWithGarden()
        {
            this.Builder.BuildUsualHouse();
            this.Builder.BuildHouseWithGarden();
        }

        public void BuildHouseWithSwimmingPool()
        {
            this.Builder.BuildUsualHouse();
            this.Builder.BuildHouseWithSwimmingPool();
        }
        public void BuildHouseWithFancyStatues()
        {
            this.Builder.BuildUsualHouse();
            this.Builder.BuildHouseWithFancyStatues();
        }
    }
}
