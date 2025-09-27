using System;
using System.Text;
using Tyuiu.ZvyaginaNY.Sprint1.Task6.V8.Lib;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Звягина Н. Ю. | ИСПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнила: Звягина Надежда Юрьевна | ИСПБ-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Напечатать все слова, перенеся их первую букву в конец.                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            try
            {
                
                Console.WriteLine("Введите текст:");
                string inputText = Console.ReadLine();

                
                if (string.IsNullOrWhiteSpace(inputText))
                {
                    Console.WriteLine("Вы ввели пустой текст.");
                    Console.ReadLine();
                    return;
                }

                
                DataService ds = new DataService();

               
                string result = ds.MoveFirstLetterToEnd(inputText);

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                
                Console.WriteLine("Исходный текст:");
                Console.WriteLine(inputText);
                Console.WriteLine();
                Console.WriteLine("Преобразованный текст:");
                Console.WriteLine(result);
                Console.WriteLine();

                
                Console.WriteLine("Подробности преобразования:");
                ShowWordTransformationDetails(inputText);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }

        static void ShowWordTransformationDetails(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n' },
                                      StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Слово -> Преобразованное слово");
            Console.WriteLine(new string('-', 40));

            DataService ds = new DataService();

            foreach (string word in words)
            {
                
                string cleanWord = ExtractLetters(word);
                if (!string.IsNullOrEmpty(cleanWord))
                {
                    string transformed = ds.MoveFirstLetterToEnd(cleanWord);
                    Console.WriteLine($"{word,-15} -> {transformed}");
                }
            }
        }

        static string ExtractLetters(string word)
        {
            StringBuilder letters = new StringBuilder();
            foreach (char c in word)
            {
                if (char.IsLetter(c))
                {
                    letters.Append(c);
                }
            }
            return letters.ToString();
        }
    }
}