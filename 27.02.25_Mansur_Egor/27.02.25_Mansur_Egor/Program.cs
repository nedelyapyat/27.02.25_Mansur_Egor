﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27._02._25_Mansur_Egor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания (от 1 до 10) или 0 для выхода:");
                if (int.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    if (taskNumber == 0) break;

                    switch (taskNumber)
                    {
                        case 1:
                            _1_BitwiseOperations.Execute();
                            break;
                        case 2:
                            _2_BitShiftOperations.Execute();
                            break;
                        case 3:
                            _3_BitCheck.Execute();
                            break;
                        case 4:
                            _4_CountOnes.Execute();
                            break;
                        case 5:
                            _5_ToggleBit.Execute();
                            break;
                        case 6:
                            _6_MultiplyVsShift.Execute();
                            break;
                        case 7:
                            _7_RoundNumber.Execute();
                            break;
                        case 8:
                            _8_CustomRound.Execute();
                            break;
                        case 9:
                            _9_CompareRoundingMethods.Execute();
                            break;
                        case 10:
                            _10_EvenCheckAndDivide.Execute();
                            break;
                        default:
                            Console.WriteLine("Некорректный номер задания.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }
        }
    }
}

