int ReadData(string line)   // чтение данных из консоли
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
  // создаём массив
int[] GenArray(int arrLength, int min, int max)
{
    int[] array = new int[arrLength];
    Random ran = new Random();
    for (int i = 0; i < arrLength; i++)
    {        // задаем пороги значений
        array[i] = ran.Next(min, max + 1);   
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
int min = ReadData("Введите min число в массиве: ");
int max = ReadData("Введите max число массиве: ");
int[] array = GenArray(arrLength, min, max);
PrintArray(array);