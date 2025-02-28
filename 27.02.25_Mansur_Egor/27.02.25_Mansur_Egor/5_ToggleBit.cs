using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    internal class _5_ToggleBit
    {
        public static void Execute()
        {
            Console.WriteLine("Введите целое число:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер бита:");
            int bitPosition = int.Parse(Console.ReadLine());

            int toggledNum = num ^ (1 << bitPosition);
            Console.WriteLine($"Число после инвертирования бита на позиции {bitPosition}: {toggledNum}");
        }
    }
}
