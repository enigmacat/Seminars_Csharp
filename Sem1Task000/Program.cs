﻿//================================================================
// # 0 Напишите программу, которая на входе принимает число и
// выдаёт его квадрат(число, умноженное на само себя).
//================================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    //int outNumber = inputNumber*inputNumber;
    int outNumber = (int)Math.Pow(inputNumber, 2);      //Встроенная библиотека
    
    Console.WriteLine(outNumber);
}