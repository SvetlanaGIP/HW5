using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4_quantity
{
    class Program
    {
        static void Main(string[] args)
        /* Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. 
         * Определить количество   нечетных положительных элементов, стоящих на четных местах.*/
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int q = 0;            

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);

                if (array[i] > 0 & array[i] % 2 != 0 & i % 2 != 0) 
                    q++;
                else
                    q=0;   

            }
            Console.WriteLine();
            
            Console.WriteLine(q);
            
            Console.ReadKey();

        }
    }
}
