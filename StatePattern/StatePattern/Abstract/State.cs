using StatePattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Abstract
{

    
    //1. Необходимо создать абстрактный класс(родительский класс состояния) в котором :

    public abstract class State
    {
        protected Phone Phone; //*Необходимо ссылаться на объект который будет менять своё состояние 

        public void SetPhone(Phone phone) //*Создать метод который будет устанавливать ссылку на объект(Конструктор не подойдет)
        {
            this.Phone = phone;
        }
        public abstract void PressButton(); //*Создать метод который нужно будет перепределять в конкретных состояниях
    }
}
