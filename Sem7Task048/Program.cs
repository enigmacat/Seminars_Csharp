//=========================================================================
// # 48 Задайте двумерный массив размера m на n, каждый элемент в массиве
//  находится по формуле: Aₘₙ =m+n. Выведите полученный массив на экран.
//===========================================================================

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
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

int[,] Fill2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
    return matr;
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
int[,] matrix = new int[m, n];

matrix = Fill2DArray(matrix);
Print2DArray(matrix);