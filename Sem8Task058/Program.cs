//================================================================
// # 58 Задайте две матрицы. Напишите программу, которая
// будет находить произведение двух матриц.
//==============================================================

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

// перемножаем матрицы
int[,] MultiArr(int[,] arrA, int[,] arrB)
{
    int[,] arrMulti = new int[arrA.GetLength(0), arrB.GetLength(1)];

    // проверка на возможность перемножения в случае,
    // если размеры матрицы (Row, Col) будут вводиться 
    // с консоли, и они могут быть не одинаковыми.        
    if (arrA.GetLength(1) != arrB.GetLength(0))
    {
        Console.WriteLine("Действие невыполнимо");
    }
    else                // перемножаем матрицы 
    {
        for (int i = 0; i < arrA.GetLength(0); i++)
        {
            for (int j = 0; j < arrB.GetLength(1); j++)
            {
                for (int k = 0; k < arrB.GetLength(0); k++)
                {
                    arrMulti[i, j] += arrA[i, k] * arrB[k, j];
                }
            }
        }
    }
    return arrMulti;
}

int[,] arrA = Fill2DArray(3, 3, 0, 9);
Console.WriteLine("Матрица A:");
Print2DArray(arrA);
Console.WriteLine();
int[,] arrB = Fill2DArray(3, 3, 0, 9);
Console.WriteLine("Матрица B:");
Print2DArray(arrB);
Console.WriteLine();
int[,] arrMulti = MultiArr(arrA, arrB);
Console.WriteLine("Матрица C=A*B:");
Print2DArray(arrMulti);


