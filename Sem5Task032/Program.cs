//==================================================================
// # 32 Напишите программу замены элементов массива: положительные 
// элементы заменить на соответствующие отрицательные и наоборот.
//====================================================================
int ReadData(string line)   // чтение данных из консоли
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
// универсальный метод генерации и заполнения массива
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
// инверсия элементов массива
int[] InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        arr[i] = arr[i] * (-1);
    }
    return arr;
}

int arrLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите минимальное значение элемента: ");
int topBorder = ReadData("Введите максимальное значение элемента: ");
int[] arr = FillArray(arrLength,downBorder, topBorder);
Print1DArr(arr);
Print1DArr(InversArray(arr));