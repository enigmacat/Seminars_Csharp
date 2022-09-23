//======================================================================
// # 51 Задайте двумерный массив. Найдите сумму элементов, находящихся
// на главной диагонали (с индексами (0,0); (1;1) и т.д.
//=======================================================================

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

int DiagSum(int[,] arr2D)
{
    int sum = 0;
    int len = arr2D.GetLength(0) > arr2D.GetLength(1) ? arr2D.GetLength(1) : arr2D.GetLength(0);
    for (int i = 0; i < len; i++)
    {
        sum = sum + arr2D[i, i];
    }
    return sum;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[,] arr = Fill2DArray(10, 15, 10, 99);

Print2DArray(arr);
int sum = DiagSum(arr);
Console.WriteLine();
PrintResult("Сумма элементов по диагонали = " + sum);