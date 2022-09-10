//===================================================================
// # 24 Напишите программу, которая принимает на вход
// число (А) и выдаёт сумму чисел от 1 до А.
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

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VarSumSimple(int numA)        // простой алгоритм вычисления
{
    int sumOfNum = 0;
    for (int i = 1; i <= numA; i++)
    {
        sumOfNum += i;
    }
    return sumOfNum;
}

int VarSumGauss(int numA)         // аналитический, метод Гаусса
{
    int sumOfNum = 0;
    sumOfNum = ((1 + numA) * numA) / 2;
    return sumOfNum;
}

int numA = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int res = VarSumSimple(numA);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
int res2 = VarSumGauss(numA);
Console.WriteLine(DateTime.Now - d2);

PrintResult("Сумма чисел от 1 до А равна: " + res);
PrintResult("Сумма чисел от 1 до А равна(Гаусс): " + res2);
