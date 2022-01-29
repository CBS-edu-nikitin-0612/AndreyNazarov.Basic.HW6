using System;

namespace Task4
{
    internal static class ArrayIntExtension
    {
        public static void Sort(this int[] array)
        {
            for (int i = array.Length-1; i >0 ; i--)
            {
                for (int a = 0; a < array.Length-1; a++)
                {
                    if(array[a]> array[a + 1])
                    {
                        var temp = array[a+1];
                        array[a + 1] = array[a];
                        array[a] = temp;
                    }
                }
            }
        }

        public static void Print(this int[] array)
        {
            Console.WriteLine();
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine();
        }
    }
}
