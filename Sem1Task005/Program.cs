﻿//==========================================================
// # 5 Напишите программу, которая на входе принимает число N,
// а на выходе показывает все целые числа от -N до N.
//===========================================================

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int inputNumberN = int.Parse(inputLineN);
    if (inputNumberN > 0)
    {
        int startNumber = (-1) * inputNumberN;
        while (startNumber < inputNumberN)
        {
            Console.Write(startNumber + ", ");
            startNumber = startNumber + 1;
        }
        Console.Write(inputNumberN);
    }
}