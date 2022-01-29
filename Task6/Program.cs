using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 600;
            Console.WriteLine(Calculator.Addition(a, b));
            Console.WriteLine(Calculator.Devision(a, b));
            Console.WriteLine(Calculator.Multiply(a, b));
            Console.WriteLine(Calculator.Substraction(a, b));
        }
    }
}
