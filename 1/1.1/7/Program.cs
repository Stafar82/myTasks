using System;

namespace task1._1._7
{
    internal class Program
    {
        public static void SortArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public static void GenerateRandomElements(int[] array)
        {
            var random = new Random();
            Console.WriteLine("Введите минимальное и максимальное значения массива : ");
            int minValue = int.Parse(Console.ReadLine());
            int maxValue = int.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
        }

        public static void PrintArray(int[] array)
        {
            foreach(var item in array)
                Console.Write(item + " ");
        }
        static void Main(string[] args)
        {
            var array = new int[10];
            GenerateRandomElements(array);

            Console.WriteLine("Исходный массив");
            PrintArray(array);

            Console.WriteLine("\nОтсортированный массив");
            SortArray(array);
            PrintArray(array);
        }
    }
}
