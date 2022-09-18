//=========================================================================
// # 39 Напишите программу, которая перевернёт одномерный массив (последний 
// элемент будет на первом месте, а первый - на последнем и т.д.)
// =========================================================================

// создание одномерного массива (рандом)
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

// печать массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// метод разворота массива созданием нового массива
int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}

// метод разворота массива
int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
}

int[] arr = FillArray(20, 1, 100);
Console.WriteLine("Исходный массив");
Print1DArr(arr);

int[] copyArray = SwapNewArray(arr);
Console.WriteLine("Новый перевёрнутый массив");
Print1DArr(copyArray);
Console.WriteLine("Исходный массив");
Print1DArr(arr);

arr = SwapArray(arr);
Console.WriteLine("Перевёрнутый исходный массив");
Print1DArr(arr);