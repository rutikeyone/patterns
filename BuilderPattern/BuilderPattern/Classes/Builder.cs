using BuilderPattern.Classes.PartsObject;
using BuilderPattern.Interfaces;
using System;

namespace BuilderPattern.Classes
{
    public class Builder : IBuilder
    {
        private Product Product = new();
        public void BuildHouseWithFancyStatues()
        {
            this.Product.Add(new FancyStatues());
        }

        public void BuildHouseWithGarage()
        {
            this.Product.Add(new Garage());
        }

        public void BuildHouseWithGarden()
        {
            this.Product.Add(new Garden());
        }

        public void BuildHouseWithSwimmingPool()
        {
            this.Product.Add(new SwimmingPool());
        }

        public void BuildUsualHouse()
        {
            this.Product.Add(new House());
        }

        public Product GetProduct()
        {
            Product Result = this.Product;
            this.Reset();
            return Result;
        }

        public void Reset()
        {
            this.Product = new();
        }
    }
}
