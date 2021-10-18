using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6_magic_box
{
    class Program
    {
        static void Main(string[] args)
        /* Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. 
         * Заполнить массив числами, вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
         * Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.*/
        {
            Console.WriteLine("Введите N, указывающее количество строк и столбцов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[,] t = new int[n, n];
            int[] sumS = new int[n];
            // int Ss = 0;

            for (int i = 0; i < n; i++)
            {
                //int S1 = 0;
                sumS[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите {0}-й элемент {1}-й строки", j + 1, i+1);
                    t[i,j] = Convert.ToInt32(Console.ReadLine());
                    sumS[i] += t[i, j];
                    // Ss += t[i,j];

                    /*if (i != 0 & j % 2 == 0)
                        t[i, j] = 0;
                    else if (i % 2 == 0 & j % 2 != 0)
                        t[i, j] = 0;
                    else
                        t[i, j] = 1;*/
                }
                Console.WriteLine();
                // Console.WriteLine(Ss);
                Console.WriteLine(sumS);
            }
            /* int[] sumS1 = new int[n]; //сумма строк
            for (int i =0;i<n;i++)
            {
                sumS1[i] = 0;
                for (int j=0;j<n;j++)
                {
                    sumS1[i] += t[i, j];
                }
            }
            Console.WriteLine(sumS1); */
            /* int[] sumS2 = new int[n]; //сумма столбцов??
            for (int i =0;i<n;i++)
            {
                for (int j=0;j<n;j++)
                {
                    sumS2[i] =0;
                }
            sumS2[i] = += t[i, j];
            }
            Console.WriteLine(sumS2); */
            Console.ReadKey();
        }
    }
}
