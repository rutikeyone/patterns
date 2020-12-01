using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRPattern.Interfaces
{
    //Создадим интерфейс для работы со всеми элементами цепи.
    public interface IHandler
    {
        IHandler SetNext(IHandler handler); //Метод нужен для установки следующего цвена цепочки

        object Handle(LevelProblem problem); //Так же он будет содержать в себе метод для обработки запроса.
    }
}
