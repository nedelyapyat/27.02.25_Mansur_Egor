using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    class _7_RoundNumber
    {
        public static void Execute()
        {
            Console.Write("Введите число с плавающей точкой: ");
            double num = double.Parse(Console.ReadLine());

            double rounded = Math.Round(num);
            Console.WriteLine($"Округлённое число: {rounded}");
        }
    }
}
