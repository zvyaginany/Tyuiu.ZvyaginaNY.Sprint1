using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZvyaginaNY.Sprint1.Task6.V8.Lib
{
    public class DataService: ISprint1Task6V8
    {
        public string MoveFirstLetterToEnd(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder();
            StringBuilder currentWord = new StringBuilder();

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    
                    currentWord.Append(c);
                }
                else
                {
                    
                    if (currentWord.Length > 0)
                    {
                        result.Append(TransformWord(currentWord.ToString()));
                        currentWord.Clear();
                    }
                    
                    result.Append(c);
                }
            }

            
            if (currentWord.Length > 0)
            {
                result.Append(TransformWord(currentWord.ToString()));
            }

            return result.ToString();
        }

        public string MoveLetterToEnd(string value)
        {
            throw new NotImplementedException();
        }

        private string TransformWord(string word)
        {
            if (word.Length <= 1)
            {
                return word;
            }

            
            return word.Substring(1) + word[0];
        }
    }
}