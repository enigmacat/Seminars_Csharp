//=================================================================
// # 57 Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных.
//===================================================================

// создаем двумерный массив целых чисел
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

// выводим двумерный массив на экран
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

// выводим на экран массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// создание и заполнение частотного словаря
int[] FreqDicLoad(int[,] arr)
{
    // создаем словарь элементов(0-9)
    int[] dic = new int[10];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // считаем и заполняем словарь 
            dic[arr[i, j]]++;
        }
    }
    return dic;
}

int[,] matr= Fill2DArray(5,5,0,9);
int [] dic = FreqDicLoad(matr);
Print2DArray(matr);
Console.WriteLine();
Print1DArr(dic);