//=============================================================
// # 35 Задайте одномерный массив из 123 случайных чисел.
// Найдите количество чисел элементов массива, значения 
// которых лежат в отрезке {10,99].
//=================================================================

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
            arr[i] = num.Next(downBorder, topBorder);
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

void PrintResult(string line)
{
    Console.WriteLine(line);
}


// int CountElem(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 10 && arr[i] < 99)
//         {
//             count++;
//         }
//     }
//     return count;
// }
/////////////////////
int CountElemBool(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            count++;
        }
    }
    return count;
}

bool Test(int a)
{
    return (a >= 10 && a <= 99);
}
//////////////////////////////////////////

int[] arr = FillArray(123, 1, 300);
Print1DArr(arr);
int count = CountElemBool(arr);
PrintResult("В массиве " + count + " элементов от 10 до 99 ");