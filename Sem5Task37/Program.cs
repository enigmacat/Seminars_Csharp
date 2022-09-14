//====================================================================
// # 37 Найдите произведение пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и тд.
// Результат запишите в новом массиве.
//=====================================================================

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

void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}


int[] Change(int[] arr)
{
    int[] outArr = new int[arr.Length / 2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return outArr;
}

int[] arr = FillArray(9, 1, 10);
Print1DArr(arr);
int[] outArr = Change(arr);
Print1DArr(outArr);




