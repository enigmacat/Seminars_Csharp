//================================================================
// # 69 Напишите программу, которая на вход принимает два числа 
// A и B. Возведите число A в целую степень B с помощью рекурсии.
//================================================================

// чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// возводим в степень рекурсивно
int RecPow(int A, int B)
{
    if (B == 1) return A;
    return A * RecPow(A, B - 1);
}

int A = ReadData("Введите число A: ");
int B = ReadData("Введите степень B: ");
int C = RecPow(A, B);
PrintResult("A^B = " + C);












