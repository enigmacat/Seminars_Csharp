//============================================================
// # 6 Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
//==============================================================

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

// находим и выводим числа в промежутке от N до 1
string LineGenRec(int numN)
{
    // точка остановки
    if (numN == 0) return "";
    string outLine = numN + " " + LineGenRec(numN - 1);

    return outLine;
}

int numN = ReadData("Введите число N: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);