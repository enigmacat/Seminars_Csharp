//====================================================================
// # 25 Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.
//================================================================

int ReadData(string line)   // чтение данных из консоли
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
// выводим результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}
// возводим заданное число в нужную степень
long Pow(int A, int B)
{
    long pow = 1;
    for (int i = 0; i < B; i++)
    {
        pow = pow * A;
    }
    return pow;
}

int A = ReadData("Введите число А: ");
int B = ReadData("Введите число В: ");

long pow = Pow(A, B);
PrintResult("A^B= " + pow);











