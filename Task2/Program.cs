using System;

namespace Task2
{
    class Program
    {
        // Не уверен что правильно понял задание и для чего нужен отдельный метод для каждой ноты
        static void Main(string[] args)
        {
            Console.WriteLine("Please specify your melody");
            var melody = MelodyParser.Parse(Console.ReadLine());
            Player.Play(melody);
        }
    }


}
