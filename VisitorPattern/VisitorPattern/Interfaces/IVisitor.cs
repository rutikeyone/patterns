using System;
using VisitorPattern.Interfaces;
using VisitorPattern.Classes;

namespace VisitorPattern.Interfaces
{
    //1.Создайте интерфейс посетителя
    public interface IVisitor
    {
        void VisitFamily(Family family); //объявите в нем методы для посещения класса
        void VisitBank(Bank bank); //объявите в нем методы для посещения класса
        void VisitCompany(Company company); //объявите в нем методы для посещения класса
    }
}
