using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task5.V4.Lib
{
    public class DataService: ISprint1Task5V4
    {
        public int SecondsToHours(int k)
        {
            
            if (k < 0 || k > 86400)
            {
                throw new ArgumentException("Количество секунд должно быть в диапазоне от 0 до 86400");
            }

           
            int hours = k / 3600;

            return hours;
        }
    }
}