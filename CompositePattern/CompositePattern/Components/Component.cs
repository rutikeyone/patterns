using System;

namespace CompositePattern.Components
{
    
    //Общий класс для всех составных компонентов дерева
    public abstract class Component
    {
         //Поле при помощи которого клиенский код может понять имеет ли объект вложенные объекты 
         protected virtual bool IsComposite { get; set; } = true; 
         //Метод, реализующий некоторое поведение
         public abstract void MobilizationOrder();

         //Методы для добавления вложенных объектов 
         public virtual void Add(Component component) { }
         //Методы для удаления вложенных объектов
         public virtual void Remove(Component component) { }

    }
}
