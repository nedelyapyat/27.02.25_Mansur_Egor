using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    class _9_CompareRoundingMethods
    {
       public static void Execute()
        {
            Console.Write("Введите число с плавающей точкой: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine($"Округление вниз (Math.Floor): {Math.Floor(num)}");
            Console.WriteLine($"Округление вверх (Math.Ceiling): {Math.Ceiling(num)}");
            Console.WriteLine($"Округление до ближайшего целого (Math.Round): {Math.Round(num)}");
        }
    }
}
