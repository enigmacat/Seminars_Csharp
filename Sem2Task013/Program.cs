﻿//========================================================
// # 13 Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
//=========================================================


Console.Write("Введите число: ");                   // Вводим число
string inputLineA = Console.ReadLine() ?? "";       // Проверяем на null 
int inputNumberA = int.Parse(inputLineA);
if (inputLineA.Length >= 3)                                 // Проверка на длину числа(наличияе третьей цифры)
{
    char[] array = inputLineA.ToCharArray();            // Преобразуем строку в массив и
    Console.WriteLine("Третья цифра: " + array[2]);     // Выводим результат
}
else                                                 // В противном случае выводим это                                                      //это сообщение
{
    Console.WriteLine("Третьей цифры нет");
}
