using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    internal class _1_BitwiseOperations
    {
        public static void Main()
        {
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"AND: {num1 & num2}");
            Console.WriteLine($"OR: {num1 | num2}");
            Console.WriteLine($"XOR: {num1 ^ num2}");
            Console.WriteLine($"NOT для первого числа: {~num1}");
        }
    }
}
