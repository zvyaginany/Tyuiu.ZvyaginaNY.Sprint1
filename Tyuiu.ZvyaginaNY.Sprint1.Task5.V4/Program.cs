using System;
using Tyuiu.ZvyaginaNY.Sprint1.Task5.V4.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Звягина Н. Ю. | ИСПБ-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Определение полных часов по секундам суток                             *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int k = 0;
            bool success = false;

           
            while (!success)
            {
                Console.Write("Введите количество секунд (0-86400): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out k))
                {
                    if (k >= 0 && k <= 86400)
                    {
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Число должно быть в диапазоне от 0 до 86400.");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите целое число.");
                }
            }

            
            int hours = ds.SecondsToHours(k);
            int minutes = (k % 3600) / 60;
            int remainingSeconds = k % 60;

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Секунда суток: {k}");
            Console.WriteLine($"Полных часов прошло: {hours}");
            Console.WriteLine();
            Console.WriteLine($"Детализация:");
            Console.WriteLine($"- Всего секунд: {k}");
            Console.WriteLine($"- Часов: {hours} (полных)");
            Console.WriteLine($"- Минут: {minutes} (в текущем часе)");
            Console.WriteLine($"- Секунд: {remainingSeconds} (в текущей минуте)");
            Console.WriteLine($"- Время: {hours:00}:{minutes:00}:{remainingSeconds:00}");

            
            Console.WriteLine("\nПримеры для сравнения:");
            Console.WriteLine($"3600 секунд = 1 час");
            Console.WriteLine($"7200 секунд = 2 часа");
            Console.WriteLine($"13257 секунд = 3 часа (как в условии)");

            Console.WriteLine("\nДля выхода нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}