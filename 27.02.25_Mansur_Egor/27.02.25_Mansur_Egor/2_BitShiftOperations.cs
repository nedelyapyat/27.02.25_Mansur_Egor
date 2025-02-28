using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    internal class _2_BitShiftOperations
    {
        public static void Execute()
        {
            Console.WriteLine("Введите целое число:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Сдвиг влево на 2 позиции: {num << 2}");
            Console.WriteLine($"Сдвиг вправо на 2 позиции: {num >> 2}");
        }
    }
}
