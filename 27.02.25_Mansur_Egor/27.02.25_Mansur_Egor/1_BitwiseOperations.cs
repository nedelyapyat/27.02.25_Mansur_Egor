using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    internal class _1_BitwiseOperations
    {
        public static void Execute()
        {
            Console.WriteLine("Введите первое целое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе целое число:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Побитовое AND: {num1 & num2}");
            Console.WriteLine($"Побитовое OR: {num1 | num2}");
            Console.WriteLine($"Побитовое XOR: {num1 ^ num2}");
            Console.WriteLine($"Побитовое NOT для первого числа: {~num1}");
        }
    }
}
