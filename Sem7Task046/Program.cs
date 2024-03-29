﻿//=================================================================
// # 46 Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
//===================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countCol, int downBorder, int topBorder)
{
    System.Random rand = new System.Random();
    int[,] arr2D = new int[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr2D[i, j] = rand.Next(downBorder, topBorder + 1);
        }
    }
    return arr2D;
}

void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Print2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.Write($"{matr[i, j]} ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row= ReadData("Введите количество строк: ");
int column= ReadData("Введите количество столбцов: ");
Console.WriteLine();
int [,] arr2D= Fill2DArray(row,column,10,99);

Print2DArray(arr2D);
Console.WriteLine();
Print2DArrayColored(arr2D);