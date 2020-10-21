using System;

namespace lol
{
    class Program
    {
        static void Text(ref string text)
        {
            text = text.Replace("а", "");
            text = text.Replace("о", "");
            text = text.Replace("э", "");
            text = text.Replace("е", "");
            text = text.Replace("и", "");
            text = text.Replace("ы", "");
            text = text.Replace("у", "");
            text = text.Replace("ё", "");
            text = text.Replace("ю", "");
            text = text.Replace("я", "");
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введи сообщение глупый троль");
            string message = Console.ReadLine();
            Text(ref message);
            
        }
    }
}
