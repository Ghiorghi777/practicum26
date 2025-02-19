using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicum26_task_2
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int size = 10; // Размер массива
            int[] array = new int[size];

            // Заполняем массив случайными числами от -10 до 10
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-10, 10); // Верхняя граница в Next эксклюзивная
            }

            // Вывод массива
            Console.WriteLine("Массив: " + string.Join(", ", array));

            // Подсчет четных элементов
            int evenCount = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenCount++;
                }
            }

            Console.WriteLine($"Количество четных элементов: {evenCount}");
            Console.Read();
        }
    }
}
