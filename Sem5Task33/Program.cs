//============================================================
// # 33 Задайте массив. Напишите программу, которая
// определяет присутствует ли заданное число в массиве.
//==============================================================
// чтение данных из консоли
int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

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

// печать элементов одномерного массива
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

// печать результата
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// нахождение заданного числа в массиве
// bool FindElem(int[] arr, int elm)
// {
//     bool res = false;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == elm)
//         {
//             res = true; break;
//         }
//     }
//     return res;
// }

//  поиск заданного числа в массиве 
// bool Contains(int[] arr, int elm)
// {
//     foreach (int item in arr)
//     {
//         if (item == elm)
//             return true;
//     }
//     return false;
// }

int FindElmInArr(int[] arr, int elm)
{
    int index = +1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            return index;
        }
    }
    return -1;
}

// вывод результата для (bool) метода, тернарный метод)
void PrintResBool(int index)
{
    // Console.WriteLine(res ? " Да" : "Нет");
    Console.WriteLine(index >= 0 ? ("Элемент найден на позиции:" + index) : "Такого элемента нет");
}

int arrLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите минимальное значение элемента: ");
int topBorder = ReadData("Введите максимальное значение элемента: ");

int[] arr = FillArray(arrLength, downBorder, topBorder);
Print1DArr(arr);
int elm = ReadData("Введите число: ");
// PrintResult(elm + " -> " + FindElem(arr, elm));
// PrintResBool(Contains(arr, elm));
PrintResBool(FindElmInArr(arr,elm));