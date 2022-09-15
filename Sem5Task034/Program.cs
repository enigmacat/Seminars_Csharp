//================================================================
// # 34 Задайте массив, заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
//==============================================================

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

// выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// считаем количество чётных чисел в массиве
int EvenCount(int[] arr)
{
    int even = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (EvenTest(arr[i])) even++;
    }
    return even;
}

// проверка на четность
bool EvenTest(int a)
{
    return (a % 2 == 0);
}

int[] arr = FillArray(20, 100, 1000);
Print1DArr(arr);
int even = EvenCount(arr);
PrintResult("Количество чётных чисел в массиве: " + even);