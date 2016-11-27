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

            //while (i < sizeArr)
            //{
            //    Console.Write("Введите элемент массива: ");
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //    i++;
            //}

            for (i = 0; i < sizeArr; i++)
            {
                Console.Write("{0}-е число: ", i++);
                array[i] = Int32.Parse(Console.ReadLine());
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

        public static void QuickSort(int[] array, int firstNum, int lastNum)
        {
            int mid = array[firstNum + (lastNum - lastNum) / 2];
            int i = firstNum;
            int j = lastNum;

            while (i <= j)
            {
                while (array[i] < mid)
                    i++;
                while (array[j] > mid)
                    j--;
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
                else { }
            }
            if (i < lastNum)
                QuickSort(array, i, lastNum);
            else { }

            if (firstNum < j)
                QuickSort(array, firstNum, j);
            else { }
        }
    }
}
