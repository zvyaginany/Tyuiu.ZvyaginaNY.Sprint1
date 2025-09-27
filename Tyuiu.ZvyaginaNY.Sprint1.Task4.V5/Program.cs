using System;
using Tyuiu.ZvyaginaNY.Sprint1.Task4.V5.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Звягина Н. Ю. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Звягина Надежда Юрьевна | ИСПБ-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
            Console.WriteLine("* Формула: 1 / |x + √y|                                                   *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            try
            {
                
                Console.Write("Введите значение x: ");
                string inputX = Console.ReadLine();

                Console.Write("Введите значение y: ");
                string inputY = Console.ReadLine();

                
                if (!double.TryParse(inputX, out double x))
                {
                    throw new ArgumentException("Ошибка! Введите корректное число для x.");
                }

                if (!double.TryParse(inputY, out double y))
                {
                    throw new ArgumentException("Ошибка! Введите корректное число для y.");
                }

                
                DataService ds = new DataService();

                
                double result = ds.Calculate(x, y);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                
                Console.WriteLine($"Формула: 1 / |x + √y|");
                Console.WriteLine($"Исходные данные: x = {x}, y = {y}");
                Console.WriteLine($"√y = {Math.Sqrt(y):F3}");
                Console.WriteLine($"x + √y = {x + Math.Sqrt(y):F3}");
                Console.WriteLine($"|x + √y| = {Math.Abs(x + Math.Sqrt(y)):F3}");
                Console.WriteLine($"Результат: {result:F3}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль! Выражение под модулем равно нулю.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }

            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}