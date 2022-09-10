//===================================================================
// # 30 Напишите программу, которая выводит массив из 8-ми элементов,
// звполненный нулями и единицами в случайном порядке.
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

int[] GenArray(int arrLength)
{
    int[] array = new int[arrLength];
    Random ran = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        array[i] = ran.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int arrLength = ReadData("Введите длину массива: ");
int[] array = GenArray(arrLength);
PrintArray(array);
 


