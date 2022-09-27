//=============================================================
// # 53 Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строки массива.
//===============================================================

// Получение данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// генерация и заполнение двумерного массива случайными числами.
void Fill2DArray(int[,] matr, int start, int stop)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(start, stop + 1);
        }
    }
}

// меняем первую и последнюю строки местами
void ChangeRows2DArray(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1, i] = temp;
    }
}

// Печать двумерного массива.
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

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matr = new int[m, n];

Fill2DArray(matr, 1, 9);
Console.WriteLine();
Print2DArray(matr);
ChangeRows2DArray(matr);
Console.WriteLine();
Print2DArray(matr);