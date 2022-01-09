using System;

namespace task1._1._4
{
    internal class Program
    {
        public static void WriteTree(int n)
        {
            int emptySpaces = n / 2;
            for (int i = 0; i < n; i++)
            {
                string emptyString = new string(' ', n - i - 1);
                string stars = new('*', i * 2 + 1);
                Console.WriteLine(emptyString + stars + emptyString);
            }
        }
        static void Main(string[] args)
        {
            int n = 3;

            Console.WriteLine(" * " + "\n * " + "\n***");
            for (int i = 0; i < n; i++)
            {
                WriteTree(i + 3);
            }
            //Console.WriteLine(3/2);
        }
    }
}
