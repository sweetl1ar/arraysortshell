using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysortshell
{
    internal class Program
    {
        public static void Shell(int[] array)
        {
            int j;
            int d = array.Length / 2;
            while (d > 0)
            {
                for (int i = 0; i < (array.Length - d); i++)
                {
                    j = i;
                    while ((j >= 0) && (array[j] > array[j + d]))
                    {
                        int tmp = array[j];
                        array[j] = array[j + d];
                        array[j + d] = tmp;
                        j -= d;
                    }
                }
                d = d / 2;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Массив до сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            Shell(array);

            Console.WriteLine();
            Console.WriteLine("Массив после сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
