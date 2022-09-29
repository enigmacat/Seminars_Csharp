//=============================================================
// # 66 Задайте значения M и N. Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
//===============================================================

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

// считаем сумму элементов в заданном промежутке
int DigitSumRec(int m, int n)
{
    if (m == n)
        return n;
    return n + DigitSumRec(m, n - 1);
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");
PrintResult("Сумма элементов от M до N = " + DigitSumRec(M, N));


