using System;

namespace lol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи сообщение глупый троль");
            string message = Console.ReadLine();
            char[] mes = message.ToCharArray();
            string fixMessage;
            for (int q = 0; q < message.Length; q++)
            {
                char a = 'а', b = 'о', c = 'э', d = 'е', e = 'и', f = 'ы', g = 'у', k = 'ё', l = 'ю', m = 'я';
                char t = 't';
                if (Array.IndexOf<char>(t, char.ToLower(message(q)))) == a | message[q] ==  b | c | d | e | f | g | k | l | m)
                {
                    mes[q] = t;
                }

            }
        }
    }
}
