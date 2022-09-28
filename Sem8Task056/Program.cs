//====================================================================
// # 56  Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//=======================================================================

// генерация и заполнение двумерного массива.
int[,] Fill2DArray(int countRow, int countCol, int start, int stop)
{
    int[,] array2D = new int[countRow, countCol];
    System.Random rnd = new System.Random();

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            array2D[i, j] = rnd.Next(start, stop + 1);
        }
    }
    return array2D;
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



// находим строку с минимальной суммой элементов
int FindMinRow(int[,] arr)
{
    int outIndexRow = -1;
    int min = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (min > sum)
        {
            min = sum;
            outIndexRow = i;
        }
        sum = 0;
    }
    return outIndexRow;
}

int[,] arr2D = Fill2DArray(5, 5, 0, 9);
int outIndexRow = FindMinRow(arr2D);
Print2DArray(arr2D);
Console.WriteLine();
Console.Write($"Строка c минимальной суммой элементов: № {outIndexRow + 1}");
