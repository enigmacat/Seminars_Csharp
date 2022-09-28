//============================================================
// # 67 Напишите программу, которая будет принимать
// на вход число N и возвращать сумму его цифр.
//=============================================================

// чтение данных из консоли
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int RecSumDigit(int num)
{
    if (num == 0) return 0;
    return num % 10 + RecSumDigit(num / 10);
}


int numN = ReadData("Введите число N: ");
int sum = RecSumDigit(numN);
PrintResult("Сумма цифр в числе: " + sum);
