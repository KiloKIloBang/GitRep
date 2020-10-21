using System;

namespace Metod
{
    class Program
    {
        static void Up(ref int[] mass)
        {
            Console.WriteLine("Введите число на которое у хотите увеличить массив");
            int add = Convert.ToInt32(Console.ReadLine());
            int[] temp = new int[mass.Length];
            Array.Copy(mass, temp, mass.Length);
            mass = new int[mass.Length + add];
            Array.Copy(temp, mass, temp.Length);
            

        }

        static void Down(ref int[] mass)
        {
            Console.WriteLine("Введите число на которое у хотите уменьшить массив");
            int rem = Convert.ToInt32(Console.ReadLine());
            int[] temp = new int[mass.Length];
            Array.Copy(mass, temp, mass.Length);
            mass = new int[mass.Length - rem];
            Array.Copy(temp, mass, temp.Length- rem);
        }
        static void Main(string[] args)
        {
            do
            {
                //Рандомный массив
                int[] original = new int[10];
                Random ran = new Random();
                for (int i = 0; i < original.Length; i++)
                {
                    original[i] = ran.Next(10);

                }
                //Вывод на экран 
                for (int i = 0; i < original.Length; i++)
                {
                    Console.Write(" " + original[i]);
                }
                Console.WriteLine();
                Console.WriteLine("Введите 1 что бы увеличить массив или 2 что бы уменьшить его");
                int q = Convert.ToInt32(Console.ReadLine());
                    if (q == 1) 
                {
                    Up(ref original);
                }
                else
                {
                    Down(ref original);
                }
                for (int i = 0; i < original.Length; i++)
                {
                    Console.Write(" " + original[i]);
                }
                Console.WriteLine();
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
