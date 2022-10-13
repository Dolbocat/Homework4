using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
