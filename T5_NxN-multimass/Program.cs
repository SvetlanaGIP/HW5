using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_NxN_multimass
{
    class Program
    {
        static void Main(string[] args)
        /*Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
        1 0 1 0 1
        0 1 0 1 0 */
        {
            Console.WriteLine("Введите N, указывающее количество строк и столбцов массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[n, n];

            
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    if (i % 2 != 0 & j%2==0)
                        t[i, j] = 0;
                    else if(i % 2 == 0 & j % 2 != 0)
                        t[i, j] = 0;
                    else 
                        t[i, j] = 1;
                    
                    Console.Write("{0,4} ", t[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
