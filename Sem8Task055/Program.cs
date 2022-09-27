//======================================================================
// # 55 Задайте двумерный массив. Напишите программу,которая заменяет
// строки на столбцы. В случае, если это невозможно, программа должна
// вывести сообщение для пользователя.
//======================================================================

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

// тест на квадратность матрицы
bool TestRotate(int[,] arr)
{
    if (arr.GetLength(0) == arr.GetLength(1))
        return true;
    else
        return false;
}
// замена строк столбцами(разворот) матрицы
int Rotate2DArray(int[,] arr)
{
    int buf = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            buf = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = buf;
        }
    }
    return buf;
};

int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matr = new int[m, n];

Fill2DArray(matr, 1, 9);
Console.WriteLine();
Print2DArray(matr);

if (TestRotate(matr))
{
    Rotate2DArray(matr);
    Console.WriteLine();
    Print2DArray(matr);
}
else
{
    Console.WriteLine();
    Console.WriteLine("Невыполнимо");
}