using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        /* Сформировать одномерный массив из 7 элементов. 
         * Заполнить массив числами, вводимыми с клавиатуры,
         * определить среднее арифметическое элементов.*/
        {
            float S = 0;

            int[] array = new int[7];
            for (int j = 0; j < 7; j++)
            {
                Console.WriteLine("Введите {0}-й элемент", j + 1);
                array[j] = Convert.ToInt32(Console.ReadLine());
                S += array[j];                
            }
            
            Console.Write("Среднее арифметиеское = {0:f2} ", S / 7);


            Console.ReadKey();
        }
    }
}
