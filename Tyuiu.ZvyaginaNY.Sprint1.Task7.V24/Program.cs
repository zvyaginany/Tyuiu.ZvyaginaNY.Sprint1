using System;
using Tyuiu.ZvyaginaNY.Sprint1.Task7.V24.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Звягина Н. Ю. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнила: Звягина Надежда Юрьевна | ИСПБ-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
            Console.WriteLine("* Формула: z = (1 + cos(√(x + 1))) / sin(15y - 4)                         *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            try
            {
                
                Console.Write("Введите значение x (x >= -1): ");
                string inputX = Console.ReadLine();

                Console.Write("Введите значение y (y ≠ (4 + πk)/15): ");
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

             
                Console.WriteLine($"Формула: z = (1 + cos(√(x + 1))) / sin(15y - 4)");
                Console.WriteLine($"Исходные данные: x = {x}, y = {y}");
                Console.WriteLine();
                Console.WriteLine("Пошаговое вычисление:");

                double step1 = x + 1;
                Console.WriteLine($"1. x + 1 = {x} + 1 = {step1}");

                double step2 = Math.Sqrt(step1);
                Console.WriteLine($"2. √(x + 1) = √({step1}) = {step2:F6}");

                double step3 = Math.Cos(step2);
                Console.WriteLine($"3. cos(√(x + 1)) = cos({step2:F6}) = {step3:F6}");

                double step4 = 1 + step3;
                Console.WriteLine($"4. 1 + cos(√(x + 1)) = 1 + {step3:F6} = {step4:F6}");

                double step5 = 15 * y - 4;
                Console.WriteLine($"5. 15y - 4 = 15*{y} - 4 = {step5:F6}");

                double step6 = Math.Sin(step5);
                Console.WriteLine($"6. sin(15y - 4) = sin({step5:F6}) = {step6:F6}");

                double step7 = step4 / step6;
                Console.WriteLine($"7. z = {step4:F6} / {step6:F6} = {step7:F6}");

                Console.WriteLine($"8. Округление до 3 знаков: {result}");

                Console.WriteLine();
                Console.WriteLine($"ОТВЕТ: z = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Знаменатель равен нулю!");
                Console.WriteLine("Это происходит когда sin(15y - 4) = 0");
                Console.WriteLine("Решите уравнение: 15y - 4 = πk, где k - целое число");
                Console.WriteLine("y ≠ (4 + πk)/15");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}