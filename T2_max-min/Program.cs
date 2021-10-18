using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_max_min
{
    class Program
    {
        static void Main(string[] args)
        /*Сформировать одномерный массив из 15 элементов, 
         * которые выбираются случайным образом из диапазона [0; 50]. 
         * Определить сумму максимального и минимального элементов массива. */
        {
            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine("Максимальное число {0}",max);
            int min = array[0];
            foreach (int a in array)
            {
                if (a < min)
                    min = a;
            }
            Console.WriteLine("Минимальное число {0}",min);
            int Sum = max + min;
            Console.WriteLine("Сумма max и min {0}",Sum);
            Console.ReadKey();
        }
    }
}
