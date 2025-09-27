using System;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task3.V13.Lib
{
    public class DataService
    {
        public double MultiplyOfDigits(double number)
        {
           
            int num = (int)number;

            
            int digit1 = num / 100;          
            int digit2 = (num / 10) % 10;     
            int digit3 = num % 10;           

            
            double result = digit1 * digit2 * digit3;

           
            return Math.Round(result, 3);
        }
    }
}