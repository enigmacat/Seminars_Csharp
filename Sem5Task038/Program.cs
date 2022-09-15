//==============================================================
// # 38 Задайте массив вещественных чисел. Найдите разницу
// между max и min элементами массива.
//===============================================================

// создаем массив вещ. чисел и заполняем случайными числами
double[] FillArray(int arrLength, double downBorder, double topBorder)
{
    // генератор случайных чисел
    Random num = new Random();
    // создаем массив
    double[] arr = new double[arrLength];

    // тест границ
    if (downBorder < topBorder)
    {
        // заполняем массив вещ. числами
        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = num.NextDouble() * (topBorder - downBorder);
        }
    }
    // возвращаем результат
    return arr;
}

// выводим на экран массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// находим min и max значения эл-тов и разницу между ними
double MaxMin(double[] arr)
{
    double max = int.MinValue;
    double min = int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return max - min;
}

// выводим результат суммирования
void PrintResult(string line)
{
    Console.WriteLine(line);
}

double[] arr = FillArray(20, 0, 30);
Print1DArr(arr);
double res = MaxMin(arr);
PrintResult("Разница между max и min значениями элементов: " + res);