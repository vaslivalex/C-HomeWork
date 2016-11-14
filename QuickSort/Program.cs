using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите желаемый размер массива: ");
            int sizeArr = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[sizeArr];
            int i = 0;

            //Заполняем массив
            while (i < sizeArr)
            {
                Console.Write("Введите элемент массива: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            //Выводим массив на экран
            Console.WriteLine("Вы ввели следующий массив чисел: ");
            for (i = 0; i < sizeArr; i++)
                Console.Write(array[i] + " ");
            Console.Write(' ');

            QuickSort(array, 0, sizeArr - 1);
            Console.WriteLine("\nОтсортированный массив чисел: ");

            // Выводим отсортированный массив
            for (i = 0; i < sizeArr; i++)
            {
                Console.Write(array[i]);
                Console.Write(' ');
            }
            Console.WriteLine();
        }

        public static void QuickSort(int[] array, int x, int y)
        {
            int mid = array[x + (y - y) / 2];
            int a = x;
            int b = y;

            while (a <= b)
            {
                while (array[a] < mid)
                    a++;
                while (array[b] > mid)
                    b--;
                if (a <= b)
                {
                    int temp = array[a];
                    array[a] = array[b];
                    array[b] = temp;
                    a++;
                    b--;
                }
            }
            if (a < y)
                QuickSort(array, a, y);

            if (x < b)
                QuickSort(array, x, b);
        }
    }
}
