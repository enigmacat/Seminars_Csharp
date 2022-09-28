//============================================================
// # 63 Задайте значение N. Напишите программу, которая
// выведет все натуральные числа в промежутке от 1 до N.
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

string LineGenRec(int numN)
{
    // точка остановки
    if (numN == 0) return "";
    string outLine = LineGenRec(numN - 1) + " " + numN;

    return outLine;
}

int numN = ReadData("Введите число N: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);

