using System;
using VisitorPattern.Interfaces;

namespace VisitorPattern.Classes
{
    //4.Создайте конкретный класс посетителя, реализуйте интерфейс, методы и логику
    public class Insurer : IVisitor
    {
        private int PriceFamily;

        private int PriceBank;

        private int PriceCompany;

        public void VisitBank(Bank bank)
        {
            switch(bank.Revenue, bank.Scale)
            {
                case (10000, ScaleOfHazard.Low):
                    PriceBank = bank.Revenue;
                    break;
                case (20000, ScaleOfHazard.Medium):
                    PriceBank = bank.Revenue * 2;
                    break;
                case (30000, ScaleOfHazard.Hight):
                    PriceBank = bank.Revenue * 3;
                    break;
                default:
                    PriceBank = 0;
                    break;

            }
        }

        public void VisitCompany(Company company)
        {
            switch (company.Revenue, company.Prestige)
            {
                case (10000, LevelPrestige.Low):
                    PriceCompany = company.Revenue;
                    break;
                case (20000, LevelPrestige.Medium):
                    PriceCompany= company.Revenue * 2;
                    break;
                case (30000, LevelPrestige.Hight):
                    PriceCompany = company.Revenue * 3;
                    break;
                default:
                    PriceCompany = 0;
                    break;

            }
        }

        public void VisitFamily(Family family)
        {
            switch (family.Level, family.IsReadyGetInsurance)
            {
                case (LevelAffluence.Low, true):
                    PriceFamily = 150;
                    break;
                case (LevelAffluence.Medium, true):
                    PriceFamily = 300;
                    break;
                case (LevelAffluence.Hight, true):
                    PriceFamily = 600;
                    break;
                default :
                    PriceFamily = 0;
                    break;
            }
        }

        public void GetPrices()
        {
            Console.WriteLine($"Price family : {PriceFamily}, price bank : {PriceBank}, price company : {PriceCompany}");
        }


    }
}
