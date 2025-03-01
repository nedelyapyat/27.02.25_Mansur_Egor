﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    internal class _3_BitCheck
    {
        public static void Execute()
        {
            Console.WriteLine("Введите целое число:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите номер бита:");
            int bitPosition = int.Parse(Console.ReadLine());

            bool isBitSet = (num & (1 << bitPosition)) != 0;
            Console.WriteLine($"Бит на позиции {bitPosition} {(isBitSet ? "установлен" : "не установлен")}.");
        }
    }
}
