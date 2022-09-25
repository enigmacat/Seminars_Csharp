//================================================================
// # 52 Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.
//=================================================================

// Получение данных от пользователя
int ReadData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// вывод результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

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

// Печатаем массив
void Print1DArrayDub(double[] arr)
{
    string arrString = String.Empty;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arrString += arr[i] + "; ";
    }
    arrString += arr[arr.Length - 1];
    Console.WriteLine(arrString);
}

// массив из сумм элементов в столбцах 2D массива
double[] CountSumCol(int[,] arr2D)
{
    double[] arr = new double[arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr[j] = arr[j] + arr2D[i, j];
        }
    }
    return DivArr(arr, arr.GetLength(0));
}

// делим элементы массива на заданное число
double[] DivArr(double[] arr, int div)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(arr[i] / div, 2);
    }

    return arr;
}

int countRow = ReadData("Введите количество строк: ");
int countCol = ReadData("Введите количество столбцов: ");
Console.WriteLine();
int[,] arr2D = Fill2DArray(countRow, countCol, 10, 99);
Print2DArray(arr2D);
Console.WriteLine();
PrintResult($"Массив средних арифметических по столбцам: ");
Print1DArrayDub(CountSumCol(arr2D));


