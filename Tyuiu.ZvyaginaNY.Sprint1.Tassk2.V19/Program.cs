using Tyuiu.ZvyaginaNY.Sprint1.Tassk2.V19.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint1.Tassk2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнила: Звягина Н. Ю. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #2                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #19                                                            *");
            Console.WriteLine("* Выполнила: Звягина Надежда Юрьевна. | ИСПб-25-1                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            

            Console.Write("Введите расстояние в дюймах: ");
            string? s = Console.ReadLine();
            int inches = int.Parse(s);

            const double inchesToMeters = 0.0254;

            double meters = inches * inchesToMeters;

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine($"Расстояние в метрах: {meters:F3}");
        }
    }



}
   
