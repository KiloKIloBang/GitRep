using System;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] original = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int vvod = Convert.ToInt32(Console.Read());
            Dz(ref original);
            for (int q = 0;q<original.Length ;q++)
            {
                Console.Write(" " + q);
            }
        }
        static int Dz(ref int[] a)
        {
            
           
            int k = Convert.ToInt32(Console.Read());
            int[] copia = new int[k];
            int vvod = 0;
            if (vvod == 1) // увеличение
            {
                for(int q = 0; q<a.Length ;q++ )
                {
                    copia[q] = a[q];
                }
                return copia[k];
            }
            else // уменьшение 
            {
                for(int q = 0 ;q < copia.Length;q++ )
                {
                    copia[q] = a[q];
                }
                return copia[k];
            }
        }
    }
}
