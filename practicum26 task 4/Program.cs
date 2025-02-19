using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum26_task_4
{
    internal class Program
    {
        static void Main()
        {
            // Явная инициализация массива
            int[] array = { 3, 7, 1, 9, 12, 5, 8 };

            // Ввод числа от пользователя
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Индексы элементов, больших {0}:", number);

            // Поиск и вывод индексов элементов, больших заданного числа
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > number)
                {
                    Console.WriteLine(i);
                }
                Console.Read();
            }
        }
    }
} 
