//============================================================
// # 42 Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
//===========================================================

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
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

string BinConvert(int A)
{
    string res = string.Empty;
    while (A > 0)
    {
        res = res + A % 2;
        A = A / 2;
    }
    return res;
}

int A = ReadData("Введите число: ");
PrintResult("Исходное число в бинарном формате: ", BinConvert(A));