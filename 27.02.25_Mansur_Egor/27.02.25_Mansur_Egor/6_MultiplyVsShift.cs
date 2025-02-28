using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    class _6_MultiplyVsShift
    {
        public static void Execute()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            int multiplyResult = num * 2;
            int shiftResult = num << 1;

            Console.WriteLine($"Результат умножения на 2: {multiplyResult}");
            Console.WriteLine($"Результат сдвига влево на 1 бит: {shiftResult}");

            // Обсуждение
            Console.WriteLine("Сдвиг обычно быстрее, чем умножение, так как это операция с битами.");
        }
    }
}
