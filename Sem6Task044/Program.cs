//===============================================================
// # 44 Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//=============================================================

// ввод данных от пользователя
int ReadData(string line)
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// вывод результата
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}

// // печать массива
// void Print1DArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         Console.Write(arr[i] + ", ");
//     }
//     Console.WriteLine(arr[arr.Length - 1]);
// }

// Фибоначчи 
string FibNum(int num)
{
    string res = string.Empty;
    int first = 0;
    int last = 1;
    int buf = 0;

    for (int i = 0; i < num; i++)
    {
        res = res + " " + first;
        buf = first + last;
        first = last;
        last = buf;
    }
    return res;
}

// int[] Fibonacci(int number)
// {
//     int[] fibonacciArr = new int[number];
//     fibonacciArr[1] = 1;
//     for (int i = 2; i < number; i++)
//     {
//         fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1];
//     }
//     return fibonacciArr;
// }

// int inputNumber = ReadData("Введите длину последовательности: ");

// Console.WriteLine($"Последовательность Фибоначчи длиной {inputNumber}:");
// Print1DArr(Fibonacci(inputNumber));

int num = ReadData("Введите длину ряда чисел Фибоначчи: ");
string line = FibNum(num);
PrintResult("Числа Фибоначчи: ", line);