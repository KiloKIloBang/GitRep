using System;

namespace Recursion
{
    class Program
    {
        static void Recursion(int a)
        {
            Console.WriteLine(a%10);
            a = a / 10;
            if (a == 0) return;
            Recursion(a);

        }
        static void Main(string[] args)
        {
            Random numb = new Random();
            int a = numb.Next();
            Console.WriteLine(a);
            Recursion(a);
        }
    }
}
