namespace Task2
{
    internal static class MelodyParser
    {
        public static Note[] Parse(string melody)
        {
            var result = new Note[melody.Length];
            for (int i = 0; i < melody.Length - 1; i++)
            {
                switch (melody[i])
                {
                    case '1':
                    case '8':
                        result[i] = Note.Do(int.Parse(melody[i].ToString()), 400);
                        break;
                    case '2':
                    case '9':
                        result[i] = Note.Re(int.Parse(melody[i].ToString()), 400);
                        break;
                    case '3':
                    case '0':
                        result[i] = Note.Mi(int.Parse(melody[i].ToString()), 400);
                        break;
                    case '4':
                        result[i] = Note.Fa(int.Parse(melody[i].ToString()), 400);
                        break;
                    case '5':
                        result[i] = Note.Sol(int.Parse(melody[i].ToString()), 400);
                        break;
                    case '6':
                        result[i] = Note.La(int.Parse(melody[i].ToString()), 400);
                        break;
                    case '7':
                        result[i] = Note.Si(int.Parse(melody[i].ToString()), 400);
                        break;
                    default:
                        result[i] = new Note(0, 400, true);
                        break;
                }
            }
            return result;
        }
    }


}
