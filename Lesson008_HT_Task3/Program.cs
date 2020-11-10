using System;

namespace Lesson008_HT_Task3
{
    class MainClass
    {
        static int[] MyReverse(int [] array)
        {
            int[] array2 = new int[10];
            int j = 0;
            for (int i = 9; i >= 0; i--)
            {
                array2[i] = array[j++];
            }
            return array2;
        }
        
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] nArr = new int[count];
            for(int i = index; i < count; i++)
            { 
                nArr[i] = array[i];
                for (int j = 0; j < count; j++)
                {
                    if (nArr[j] == 0)
                    {
                        nArr[j] = 1;
                    }
                }
            }

            return nArr;
        }
        public static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for(int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(100);
                Console.Write($"{array[i]}" + " ");
            }
            Console.WriteLine();
            int[] Reverse = MyReverse(array);
            for(int i =0; i < 10; i++)
            {
                Console.Write($"{Reverse[i]}" + " ");
            }
            Console.WriteLine();
            int[] Sub = SubArray(array,4,10);
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"{Sub[i]}" + " ");
            }
        }
    }
}
