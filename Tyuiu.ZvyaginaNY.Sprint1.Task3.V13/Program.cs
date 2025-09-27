using System;
using Tyuiu.ZvyaginaNY.Sprint1.Task3.V13.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Звягина Н. Ю. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнила: Звягина Наталья Юрьевна | ПКТб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая позволяет найти произведение цифр          *");
            Console.WriteLine("* заданного трехзначного числа. Ответ округлите до 3 знаков после запятой.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            Console.Write("Введите трехзначное число: ");
            string input = Console.ReadLine();

            
            if (!int.TryParse(input, out int number) || number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка! Введите корректное трехзначное число.");
                Console.ReadLine();
                return;
            }

           
            DataService ds = new DataService();

            
            double result = ds.MultiplyOfDigits(number);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

           
            Console.WriteLine($"Произведение цифр числа {number} = {result}");
            Console.WriteLine($"Цифры числа: {number / 100} * {(number / 10) % 10} * {number % 10} = {result}");

            Console.ReadLine();
        }
    }
}