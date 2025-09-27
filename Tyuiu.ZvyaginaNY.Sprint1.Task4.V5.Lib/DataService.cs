using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task4.V5.Lib
{
    public class DataService: ISprint1Task4V5
    {
        public double Calculate(double x, double y)
        {
           
            if (y < 0)
            {
                throw new ArgumentException("Значение y не может быть отрицательным для извлечения квадратного корня");
            }

            
            double expression = x + Math.Sqrt(y);

            
            double absoluteValue = Math.Abs(expression);

            
            if (absoluteValue == 0)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен нулю");
            }

            
            double result = 1.0 / absoluteValue;
            return Math.Round(result, 3);
        }
    }
}