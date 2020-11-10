using System;

namespace Lesson008_HT_Task4
{
    class MainClass
    {
        static int[] incr (int[] array, int N)
        {
            int[] arr2 = new int[N + 1];
            for(int i = 0; i < N; i++)
            {
                arr2[i] = array[i];
            }
            return arr2;
        }
        static int[] add(int[] arr, int value, int N)
        {
            int[] firstArray = new int[N+1];
            firstArray[1] = value;
            firstArray[0] = arr[0];
            int m = 1;
            for(int i = 2; i < N + 1; i++)
            {
                firstArray[i] = arr[m++];
            }
            return firstArray;
        }
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(100);
                Console.Write($"{array[i]}" + " ");
            }
            Console.WriteLine(" ");
            int[] incrArr = incr(array,10);
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{incrArr[i]}" + " ");
            }
            Console.WriteLine(" ");
            int[] addArr = add(array, 12, 10);
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{addArr[i]}" + " ");
            }
        }
    }
}
