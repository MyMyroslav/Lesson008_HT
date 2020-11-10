using System;

namespace Lesson008_HT_Task2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Random rnd = new Random();
            Console.WriteLine(" ");
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine(" ");
            int maxEl = array[0];
            for (int i = 0; i < n; i++)
            {
                if (array[i] > maxEl)
                    maxEl = array[i];
            }
            Console.WriteLine($"Max = {maxEl}");
           
            int minEl = array[0];
            for (int i = 0; i < n; i++)
            {
                if (array[i] < minEl)
                    minEl = array[i];
            }
            Console.WriteLine($"Min = {minEl}");
            int sum = 0;
            for(int i =0; i<n; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Sum = {sum}");
            double middleSum = 0;
            double middle = 0;
            for (int i = 0; i < n; i++)
            {
                middleSum += array[i];
                middle = middleSum / n;
            }
            Console.WriteLine($"Middle = {middle}");
            for(int i = 0; i < n; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.WriteLine($"Odd = {array[i]}");
                }
            }
        }
    }
}
