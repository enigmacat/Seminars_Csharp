//==============================================================
// # 26 Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
//==============================================================

int ReadData(string line)   // чтение данных из консоли
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// вариант с длиной строки
int CalcDigiString(int num)
{
    string numString = num.ToString();
    return numString.Length;
}
// вариант с логарифмом
int CalcDigit(int num)
{
    return (int)(Math.Log10(num) + 1);
}
// вариант подсчёта
int DigitCount(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число: ");

int count = CalcDigiString(num);
int count1 = CalcDigit(num);
int count2 = DigitCount(num);

PrintResult("(строка) Количество цифр в числе: " + count);
PrintResult("(логарифм) Количество цифр в числе: " + count1);
PrintResult("(подсчёт) Количество цифр в числе: " + count2);