using System;

namespace randomasss

{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[9]; // Массив
            int temp; //Временная переменная
            int[] tempMas = new int[9];
            int index, kull, pop = 0;
            int schet = 0; //Переменная для подсчета результатов
            bool result; //Результат проверки
            Random ran = new Random();
            Console.WriteLine("Сколько массивов вы хотите увидеть?");
            int progon = Convert.ToInt32(Console.ReadLine());
            for(int w = 0; w < progon; w++)
            { 
            do
            {
                   
                    result = false;   
                    // Заполняем рандомом массив
                    for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = ran.Next(100);
                }

                    for(int i = 0; i < mas.Length; i++)
                    {
                        tempMas[i] = mas[i];
                    }

                //Сортируем массив
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }

                    schet++;
                    //Проверяем условия
                if (mas[0] != mas[1])
                {
                    if (mas[1] == mas[2] & mas[2] != mas[3] & mas[3] == mas[4] & mas[4] != mas[5] & mas[5] == mas[6] & mas[6] != mas[7] & mas[7] == mas[8])//1
                    {
                        result = true;
                            
                    }
                }
                else if (mas[1] != mas[2] & mas[2] != mas[3] & mas[3] == mas[4] & mas[4] != mas[5] & mas[5] == mas[6] & mas[6] != mas[7] & mas[7] == mas[8]) //2
                {
                    result = true;
                        
                    }
                else if (mas[1] != mas[2] & mas[2] == mas[3] & mas[3] != mas[4] & mas[4] != mas[5] & mas[5] == mas[6] & mas[6] != mas[7] & mas[7] == mas[8])//3
                {
                    result = true;
                        
                    }
                else if (mas[1] != mas[2] & mas[2] == mas[3] & mas[3] != mas[4] & mas[4] == mas[5] & mas[5] != mas[6] & mas[6] != mas[7] & mas[7] == mas[8])//4
                {
                    result = true;
                }
                else if (mas[1] != mas[2] & mas[2] == mas[3] & mas[3] != mas[4] & mas[4] == mas[5] & mas[5] != mas[6] & mas[6] == mas[7] & mas[7] != mas[8]) //5
                {
                    result = true;
                }
            }
            while (result == false);
               // Поиск элемента массива
                for(index = 0;index < tempMas.Length ;index++ )
                {
                    int lol = 1;
                    kull = 0;
                    for (int o = 0; o < tempMas.Length; o++)
                    {
                        if (tempMas[index] == tempMas[o])
                        {
                            kull++;
                        }

                    }
                    if(lol == kull)
                    {
                        pop = index;
                        break;
                    }

                }

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(tempMas[i] + " ");
            }
                Console.Write($" " + "Индекс элемента = " + pop);
                Console.WriteLine();
        }

            Console.WriteLine("Количество провереных массивов" + schet);

        }
    }
}

