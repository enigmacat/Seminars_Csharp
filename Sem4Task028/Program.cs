//================================================================
// # 28 Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
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

long MultF(int numF)
{
    int i = 1;
    long num1 = 1;
    while (i <= numF)
    {
        num1 = num1 * i;
        i++;
    }
    return num1;
}
int numF = ReadData("Введите число: ");
long num1 = MultF(numF);
PrintResult("Произведение всех чисел до N = " + num1);

long CalcFact(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;

    }
    return factorial;
}
int num = ReadData("Введите число: ");
long factorial = CalcFact(num);
PrintResult("Факториал равен: " + factorial);

long CalcData(int numR)
{
    if (numR ==1)
       return 1;
    return numR*CalcData(numR-1);
}
int numR = ReadData("Введите число: ");
long numRec = CalcData(16);
PrintResult("Факториал(рекурсия) равен " + numRec);








