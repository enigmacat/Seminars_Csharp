//================================================================
// # 47 Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
//============================================================

// ввод данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// создаем двумерный массив случайных вещественных чисел 
double[,] Fill2DArray(int countRow, int countCol, double downBorder, double topBorder)
{
    System.Random rand = new System.Random();
    double[,] arr2D = new double[countRow, countCol];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countCol; j++)
        {
            arr2D[i, j] = rand.NextDouble() * (topBorder - downBorder);
        }
    }
    return arr2D;
}

// выводим массив на экран
void Print2DArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(($"{Math.Round((matr[i, j]),2)} \t"));
        }
        Console.WriteLine();
    }
}

int m = ReadData("Введите количество строк: ");
int n = ReadData("Введите количество столбцов: ");
double[,] arr2D = Fill2DArray(m, n, 10, 99);
Print2DArray(arr2D);