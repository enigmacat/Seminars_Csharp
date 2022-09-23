//=================================================================
// # 49 Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените этиэлементы на их квадраты.
//===================================================================

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

int[,] Update2DArr(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr2D.GetLength(1); j = j + 2)
        {
            arr2D[i, j] = arr2D[i, j] * arr2D[i, j];
        }
    }
    return arr2D;
}

int[,] matr = Fill2DArray(10, 15, 10, 99);
Print2DArray(matr);
Console.WriteLine();
int[,] matrix = Update2DArr(matr);
Print2DArray(matrix);