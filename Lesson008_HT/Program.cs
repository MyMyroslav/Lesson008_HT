using System;

namespace Lesson008_HT
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int[] array = new int[10];
            for(int i = 0; i < 10; i++)
            {
                array[i] = 2 * 2 + i;
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(" ");
            for(int i = 9 ; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }


        }
    }
}
