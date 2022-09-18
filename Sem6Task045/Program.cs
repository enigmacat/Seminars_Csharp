//====================================================================
// # 45 Напишите программу, которая будет создавать копию заданного  
// одномерного массива с помощью поэлементного копирования.
//===================================================================

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

// копируем массив
int[] CopyArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[i];
    }
    return outArr;
}

int[] arr = FillArray(30,0,999);
Print1DArr(arr);
int[] outArr= CopyArr(arr);
Print1DArr(outArr);
Console.WriteLine();


Print1DArr((int[])arr.Clone());


