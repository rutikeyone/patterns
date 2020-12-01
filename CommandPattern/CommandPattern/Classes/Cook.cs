using System;


namespace CommandPattern.Classes
{
    /*2. Создайте класс получателя в котором будет заключена вся бизнес логика и который будет одним 
         из звеньев цепи отправитель-команда-получатель */
    public class Cook
    {
        public void GetOrder(Menu order)
        {
            if(order == Menu.Fries)
            {
                PrepareFries();
            }


            if(order == Menu.Soup)
            {
                PrepareSoup();
            }
        }



        private void PrepareSoup()
        {
            Console.WriteLine("Cook prepare soup \n");
            //Cooking logic fries
        }

        private void PrepareFries()
        {
            Console.WriteLine("Cook prepare fries \n");
            //Cooking logic fries
        }
    }
}
