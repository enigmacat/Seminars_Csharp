//============================================================
// # 65 Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
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

string RecMN(int M, int N)
{
    if (M == N) return N.ToString();
    if (M < N)
        return M + " " + RecMN(M + 1, N);
    else
        return M + " " + RecMN(M - 1, N);
}

int M = ReadData("Введите число M: ");
int N = ReadData("Введите число N: ");
PrintResult(RecMN(M, N));
