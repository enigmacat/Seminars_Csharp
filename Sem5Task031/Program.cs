//=================================================================================
// # 31 Задайте массив из 12 эл-тов, заполненный случайными числами из 
// промежутка [9,9].  Найдите сумму положительных и отрицательных эл-тов массива.
//==================================================================================

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
// печатаем одномерный массив
void Print1DArr(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}
// суммируем положительные и отрицательные элементы массива
int[] NegativPositivSums(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[i];
        }
        else
        {
            sums[1] += arr[i];
        }
    }
    return sums;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int arrLength = ReadData("Введите длину массива: ");
int topBorder = ReadData("Введите верхний предел массива: ");
int downBorder = ReadData("Введите нижний предел массива: ");
// выводим на экран массив
int[] inputArray = FillArray(arrLength, downBorder, topBorder);
Print1DArr(inputArray);
// выводим на экран суммы элементов
int[] sums = NegativPositivSums(inputArray);
PrintResult("Сумма >0: " + sums[0] + " " + "Сумма <0: " + sums[1]);
Print1DArr(sums);