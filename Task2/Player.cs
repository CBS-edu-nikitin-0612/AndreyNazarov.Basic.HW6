using System;

namespace Task2
{
    internal static class Player
    {
        public static void Play(Note[] melody)
        {
            for (int i = 0; i < melody.Length - 1; i++)
            {
                if (melody[i].IsPouse)
                    continue;
                Console.Beep(melody[i].Frequency, melody[i].DurationMS);
            }
        }
    }
}
