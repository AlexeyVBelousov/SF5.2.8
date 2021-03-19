using System;

namespace SF5._2._8
{
    class Program
    {
        static int[] GetArrayFromConsole(int size)
        {
            var result = new int[size];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}: ", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
        static void PrintArrayToConsole(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Элемент отсортированного массива номер {0}: {1}", i + 1, array[i]);
            }
        }

        static int[] SortArray(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minarr = arr[i];

                for (int k = i; k < arr.Length; k++)
                {
                    if (arr[k] < minarr)
                    {
                        int swap = arr[i];
                        arr[i] = arr[k];
                        arr[k] = swap;
                        minarr = arr[i];
                    }
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива для ввода и сортировки:");
            int arraysize = int.Parse(Console.ReadLine());

            var array = GetArrayFromConsole(arraysize);
            var sortedarray = SortArray(array);
            PrintArrayToConsole(sortedarray);
        }
    }
}
