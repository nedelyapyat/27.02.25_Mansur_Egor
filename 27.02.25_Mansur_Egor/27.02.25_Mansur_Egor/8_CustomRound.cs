using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    class _8_CustomRound
    {
        public static void Execute()
        {
            Console.Write("Введите число с плавающей точкой: ");
            double num = double.Parse(Console.ReadLine());

            Console.Write("Введите количество десятичных знаков: ");
            int decimalPlaces = int.Parse(Console.ReadLine());

            double factor = Math.Pow(10, decimalPlaces);
            double rounded = Math.Floor(num * factor + 0.5) / factor;

            Console.WriteLine($"Округлённое число: {rounded}");
        }
    }
}
