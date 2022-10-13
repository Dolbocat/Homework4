using System;

namespace Dolbocat.Utils
{
    public class OutputHelpers
    {
        public static void PrintInfo(int homeworknumber, string fio)
        {
            Console.WriteLine($"Домашняя работа. урок: {homeworknumber}");
            Console.WriteLine($"Студент {fio}");
            Console.WriteLine("==========================================\n");
        }

    }
}
