using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int[] testArray = new int[20];
            for (int i = 0; i < testArray.Length-1; i++)
            {
                testArray[i] = rnd.Next(1, 100);
            }

            testArray.Print();
            testArray.Sort();
            testArray.Print();
        }
    }