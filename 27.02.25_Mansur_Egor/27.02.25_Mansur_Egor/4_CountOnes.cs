using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    internal class _4_CountOnes
    {
        public static void Execute()
        {
            Console.WriteLine("Введите целое число:");
            int num = int.Parse(Console.ReadLine());

            int count = 0;
            while (num != 0)
            {
                count += num & 1;
                num >>= 1;
            }
            Console.WriteLine($"Количество единиц: {count}");
        }
    }
}
