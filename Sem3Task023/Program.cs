//===============================================================
// # 23 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
//===============================================================

int ReadData(string line)   // чтение данных из консоли
{
    //Выводим сообщение
    Console.Write(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}
// Создаём ряд чисел до заданного числа и возводим в заданную степень
string LineNum(int numberNum, int pow)
{
    int i = 1;
    string outLine = string.Empty;
    while (i < numberNum)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
        i++;
    }
    outLine = outLine + Math.Pow(numberNum, pow);
    return outLine;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число N: ");
Console.WriteLine();
PrintResult(LineNum(num,1));  // выводим ряд чисел до заданного N
Console.WriteLine();
PrintResult(LineNum(num,3));  // выводим ряд чисел, возведённых в заданную степень