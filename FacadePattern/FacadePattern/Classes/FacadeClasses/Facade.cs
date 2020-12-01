using System;
using FacadePattern.Classes.Subsystems;

namespace FacadePattern.Classes.FacadeClasses
{
    //Конкретный фасад который принимает в себя сложные компоненты и представляет простой интерфейс 
    public class Facade
    {
        private Delivery Delivery { get; set; } //Добавление сложного компонента
        private Package  Package { get; set; }//Добавление сложного компонента
        private PaymentSystem PaySystem { get; set; }//Добавление сложного компонента
        private Provider Provider { get; set; }//Добавление сложного компонента
        private Taxes PayTaxes { get; set; }//Добавление сложного компонента
        private Warehouse Warehouse { get; set; }//Добавление сложного компонента

        //Инициализация сложных компонентов
        public Facade(Delivery delivery, Package package, PaymentSystem paymentSystem, Provider provider, Taxes taxes, Warehouse warehouse)
        {
            this.Delivery = delivery;
            this.Package = package;
            this.PaySystem = paymentSystem;
            this.Provider = provider;
            this.PayTaxes = taxes;
            this.Warehouse = warehouse;
        }

        //Какая-то логика для работы со сложным компонентом
        public void MakeOrder()
        {
            PaySystem.PayGoods();//Заказчик оплачивает товар
            PayTaxes.PayTaxes();//Заказчик платит налог
            Provider.Deliver();//Поставщик доставляет товар на склад
            Warehouse.ReceiveGoods();//Товар завозится на склад
            Package.PackGoods();//Товар упаковывают
            Delivery.DevileryGoods();//Товар доставляют
            
        }
    }
}
