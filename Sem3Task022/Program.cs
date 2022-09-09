//===============================================================
// # 22 Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.
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

string LineNum(int numberNum, int pow)
{
    int i = 0;
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
// string linetop = LineNum(num,1);
// string linedown = LineNum(num,2);
PrintResult(LineNum(num,1));
Console.WriteLine();
PrintResult(LineNum(num,2));