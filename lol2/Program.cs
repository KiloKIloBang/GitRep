using System;
using System.Globalization;
using System.Threading;

namespace Text
{
    class Program
    {

        static void Impostor(ref string text)
        {
            text = text.Replace("!", "");
            text = text.Replace("?", "");
            text = text.Replace(".", "");
            text = text.Replace(",", "");
            text = text.Replace("'", "");
            text = text.Replace(":", "");
            text = text.Replace(";", "");
            text = text.Replace("-", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace("<", "");
            text = text.Replace(">", "");
        }

        static void FirstUpper(ref string text)
        {
            
            string temp = "";
            string[] words = text.Split(' ');
            for (int q = 0; q < words.Length; q++)
            {
                
                if (words[q].Length > 1) words[q] = words[q].Substring(0, 1).ToUpper() + words[q].Substring(1, words[q].Length - 1).ToLower();
                else words[q] = words[q].ToUpper();

                
                temp = temp + words[q];
                
            }
           
            Console.WriteLine(temp);
            
        }
        static void Main(string[] args)
        {
            do
            {
                string message = Console.ReadLine();
                Console.Clear();
                Impostor(ref message);
                FirstUpper(ref message);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);



        }
    }
}
