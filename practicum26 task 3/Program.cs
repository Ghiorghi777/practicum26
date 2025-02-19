using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum26_task_3
{
    internal class Program
    {
        static void Main()
        {
            int size = 10; // Размер массива
            int[] array = new int[size];

            // Заполнение массива индексами
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            // Вывод массива с помощью foreach
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.Read();
        }
    }

}

