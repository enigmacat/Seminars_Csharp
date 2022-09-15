//===================================================================
// # 36 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//===================================================================

// создаем массив целых чисел и заполняем случайными числами
int[] FillArray(int arrLength, int downBorder, int topBorder)
{
    // создаем массив
    int[] arr = new int[arrLength];
    // генератор случайных чисел
    Random num = new Random();
    // тест границ
    if (downBorder < topBorder)
    {
        // заполняем массив
        for (int i = 0; i < arrLength; i++)
        {
            arr[i] = num.Next(downBorder, topBorder + 1);
        }
    }
    // возвращаем результат
    return arr;
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

// находим и суммируем числа на нечётных позициях
int OddPositionSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}

// выводим результат суммирования
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[] arr = FillArray(10, -10, 10);
Print1DArr(arr);
int sum = OddPositionSum(arr);
PrintResult("Сумма элементов на нечётных позициях = " + sum);

