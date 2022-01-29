namespace Task2
{
    internal class Note
    {
        public int Frequency { get; private set; }
        public int DurationMS { get; private set; }
        public bool IsPouse { get; private set; }
        public Note(int frequency, int durationMS, bool isPause = false)
        {
            Frequency = frequency;
            DurationMS = durationMS;
            IsPouse = isPause;
        }
        public static Note Do(int octave, int durationMS)
        {
            int frequency = (octave) switch
            {
                1 => 100,
                2 => 200,
                3 => 300,
                4 => 400,
                5 => 500,
                6 => 600,
                7 => 700,
                8 => 800,
                9 => 900,
                _ => 1000
            };
            return new Note(frequency, durationMS);
        }
        public static Note Re(int octave, int durationMS)
        {
            int frequency = (octave) switch
            {
                1 => 100,
                2 => 200,
                3 => 300,
                4 => 400,
                5 => 500,
                6 => 600,
                7 => 700,
                8 => 800,
                9 => 900,
                _ => 1000
            };
            return new Note(frequency, durationMS);
        }
        public static Note Mi(int octave, int durationMS)
        {
            int frequency = (octave) switch
            {
                1 => 100,
                2 => 200,
                3 => 300,
                4 => 400,
                5 => 500,
                6 => 600,
                7 => 700,
                8 => 800,
                9 => 900,
                _ => 1000
            };
            return new Note(frequency, durationMS);
        }
        public static Note Fa(int octave, int durationMS)
        {
            int frequency = (octave) switch
            {
                1 => 100,
                2 => 200,
                3 => 300,
                4 => 400,
                5 => 500,
                6 => 600,
                7 => 700,
                8 => 800,
                9 => 900,
                _ => 1000
            };
            return new Note(frequency, durationMS);
        }
        public static Note Sol(int octave, int durationMS)
        {
            int frequency = (octave) switch
            {
                1 => 100,
                2 => 200,
                3 => 300,
                4 => 400,
                5 => 500,
                6 => 600,
                7 => 700,
                8 => 800,
                9 => 900,
                _ => 1000
            };
            return new Note(frequency, durationMS);
        }
        public static Note La(int octave, int durationMS)
        {
            int frequency = (octave) switch
            {
                1 => 100,
                2 => 200,
                3 => 300,
                4 => 400,
                5 => 500,
                6 => 600,
                7 => 700,
                8 => 800,
                9 => 900,
                _ => 1000
            };
            return new Note(frequency, durationMS);
        }
        public static Note Si(int octave, int durationMS)
        {
            int frequency = (octave) switch
            {
                1 => 100,
                2 => 200,
                3 => 300,
                4 => 400,
                5 => 500,
                6 => 600,
                7 => 700,
                8 => 800,
                9 => 900,
                _ => 1000
            };
            return new Note(frequency, durationMS);
        }
    }


}
