using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    class _10_EvenCheckAndDivide
    {
        static void Execute()
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            // Проверка на четность
            bool isEven = (num & 1) == 0;
            Console.WriteLine(isEven ? "Число чётное" : "Число нечётное");

            if (isEven)
            {
                // Деление на 3 и округление
                double result = (num / 3.0);
                Console.WriteLine($"Результат деления на 3 и округления: {Math.Round(result)}");
            }
        }
    }
}
