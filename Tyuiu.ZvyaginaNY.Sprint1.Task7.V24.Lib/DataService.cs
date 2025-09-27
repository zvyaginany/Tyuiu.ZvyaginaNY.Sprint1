using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task7.V24.Lib
{
    public class DataService: ISprint1Task7V24
    {
        public double Calculate(double x, double y)
        {
            
            double denominator = Math.Sin(15 * y - 4);
            if (Math.Abs(denominator) < 1e-15) 
            {
                throw new DivideByZeroException("Знаменатель равен нулю. Вычисление невозможно.");
            }

            
            if (x + 1 < 0)
            {
                throw new ArgumentException("Выражение под корнем (x + 1) не может быть отрицательным.");
            }

            
            double sqrtValue = Math.Sqrt(x + 1);
            double cosValue = Math.Cos(sqrtValue);
            double numerator = 1 + cosValue;

            
            double result = numerator / denominator;

            
            return Math.Round(result, 3);
        }
    }
}